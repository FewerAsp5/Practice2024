using FormView.PracticeDataSetTableAdapters;
using FormView.Properties;
using PracticeTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView
{
    public partial class MainForm : Form
    {
        private readonly LoginForm loginForm = new LoginForm();
        private PracticeDataSet.USERSRow currentUser = null;
        private readonly Dictionary<RoleType, List<Control>> controls;
        private readonly ImageLoader photo;
        private readonly DatabaseWatcher completeWatcher;
        private readonly DatabaseWatcher statusWatcher;

        public MainForm()
        {
            InitializeComponent();
            photo = new ImageLoader(Photo, PhotoLoadingError);

            completeWatcher = new DatabaseWatcher(
                () => RequestsTableAdapter.GetDataForCompleteWatching(currentUser.userID), 
                (table, row) => ((PracticeDataSet.RequestsDataTable)table).Rows.Find(((PracticeDataSet.RequestsRow)row).requestID),
                2000);
            completeWatcher.OnDataNew += ClientWatcher_OnRequestCompleted;

            statusWatcher = new DatabaseWatcher(
                () => RequestsTableAdapter.GetDataForStatusWatching(),
                (table, row) => ((PracticeDataSet.RequestsDataTable)table).Rows.Find(((PracticeDataSet.RequestsRow)row).requestID),
                2000);
            statusWatcher.OnDataChanged += ClientWatcher_OnRequestStatusChanged;
            statusWatcher.OnDataNew += ClientWatcher_OnNewRequest;
            statusWatcher.OnDataAbsent += ClientWatcher_OnRequestAbsent;

            controls = new Dictionary<RoleType, List<Control>>()
            {
                {
                    RoleType.None,
                    new List<Control>()
                    { }
                },
                {
                    RoleType.Manager,
                    new List<Control>()
                    {
                        Requests,
                        NewRequest,
                        Clients,
                        AllUsers,
                        OngoingTech,
                        EnterLog,
                    }
                },
                {
                    RoleType.Master,
                    new List<Control>()
                    {
                        Requests,
                    }
                },
                {
                    RoleType.Operator,
                    new List<Control>()
                    {
                        Requests,
                        Clients,
                    }
                },
                {
                    RoleType.Client,
                    new List<Control>()
                    {
                        Requests,
                        NewRequest,
                    }
                }
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TypeTableAdapter.Fill(PracticeDataSet.TYPE);
            UsersTableAdapter.Fill(PracticeDataSet.USERS);

            Login();
            if (currentUser == null)
            {
                Close();
            }
        }

        private void Login()
        {
            loginForm.Users = PracticeDataSet.USERS;
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                currentUser = loginForm.User;
                CurrentUser.Text = currentUser.fio;
                Role.Text = PracticeDataSet.TYPE.First(t => t.typeID == currentUser.type).role;
                LoginLogout.Text = "Выйти";

                photo.LoadImage(currentUser.IsphotoNull() ? null : currentUser.photo);

                var role = (RoleType)currentUser.type;
                if (role == RoleType.Client)
                {
                    completeWatcher.StartWatching();
                }
                else if (role == RoleType.Operator)
                {
                    statusWatcher.StartWatching();
                }

                UpdateRoleAccess((RoleType)currentUser.type);
            }
        }

        private void LoginLogout_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                currentUser = null;
                CurrentUser.Text = "";
                Role.Text = "";
                photo.ResetImage();
                LoginLogout.Text = "Войти";
                completeWatcher.StopWatching();
                UpdateRoleAccess(RoleType.None);
            }
            else
            {
                Login();
            }
        }

        private void UpdateRoleAccess(RoleType roleType)
        {
            var c = controls.Values.SelectMany(l => l).Distinct().ToList();
            EnableDisableControls(c, false);

            c = controls[roleType];
            EnableDisableControls(c, true);
        }

        private void EnableDisableControls(List<Control> controls, bool enable)
        {
            controls.ForEach(c => c.Enabled = enable);
        }

        private void Requests_Click(object sender, EventArgs e)
        {
            var form = new RequestsForm(currentUser);
            form.ShowDialog(this);
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            var form = new ClientsForm(RoleType.Client, currentUser.userID);
            form.ShowDialog(this);
        }

        private void AllUsers_Click(object sender, EventArgs e)
        {
            var form = new ClientsForm(RoleType.None, currentUser.userID);
            form.ShowDialog(this);
        }

        private void NewRequest_Click(object sender, EventArgs e)
        {
            if ((RoleType)currentUser.type != RoleType.Client && !UsersTableAdapter.GetDataByType((int)RoleType.Client).Any())
            {
                MessageBox.Show(this, "Невозможно добавить заявку - в системе отсутствуют клиенты. Необходимо добавить хотя бы одного клиента.",
                    "Ошибка добавления заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new NewOrderForm(currentUser);
            while (true)
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(form.Description))
                        if (MessageBox.Show(this, "Необходимо описать неисправность. Продолжить?", "Ошибка формирования заявки",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            continue;
                        else
                            return;

                    if (string.IsNullOrWhiteSpace(form.TechName))
                        if (MessageBox.Show(this, "Необходимо указать название техники. Продолжить?", "Ошибка формирования заявки",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            continue;
                        else
                            return;

                    var techTable = OrgTechModelTableAdapter.GetData();
                    var newRow = (PracticeDataSet.orgTechModelRow)techTable.NewRow();
                    newRow.TechTypeID = form.TechType;
                    newRow.Model = form.TechName;
                    techTable.Rows.Add(newRow);
                    OrgTechModelTableAdapter.Update(techTable);

                    RequestsTableAdapter.Insert(DateTime.Now.Date, form.Description, "Ноавя заявка", null, "", newRow.orgTechModelID, null, form.Client);

                    MessageBox.Show(this, $"Новая заявка успешно добавлена пользователем {PracticeDataSet.USERS.FindByuserID(form.Client).fio}",
                        "Заявка добавлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                break;
            }
        }

        private void OngoingTech_Click(object sender, EventArgs e)
        {
            var form = new OngoingTechForm();
            form.ShowDialog(this);
        }

        private void EnterLog_Click(object sender, EventArgs e)
        {
            var форма = new EnterLogForm();
            форма.ShowDialog(this);
        }

        private void ClientWatcher_OnRequestCompleted(DatabaseWatcher sender, DataRow changedRow)
        {
            var requestId = ((PracticeDataSet.RequestsRow)changedRow).requestID;
            var message = $"Появились новости по Вашему заказу номер {requestId}.\nЗаказ готов к выдаче.";
            ShowNotification(message);
        }

        private void ClientWatcher_OnRequestStatusChanged(DatabaseWatcher sender, DataRow changedRow)
        {
            var requestId = ((PracticeDataSet.RequestsRow)changedRow).requestID;
            var requestRow = (PracticeDataSet.RequestsRow)RequestsTableAdapter.GetRequestById(requestId).Rows[0];
            var masterRow = requestRow.IsmasterIDNull() ? null : (PracticeDataSet.USERSRow)PracticeDataSet.USERS.Rows.Find(requestRow.masterID);
            var masterFio = masterRow == null ? "<не установлен>" : masterRow.fio;
            var message = $"Появились новости по заказу номер {requestRow.requestID}.\nТекущий статус заказа: {requestRow.requestStatus}.\nМастер: {masterFio}";
            if (!requestRow.IscomplectionDateNull())
                message += "\nЗаказ готов к выдаче.";
            ShowNotification(message);
        }

        private void ClientWatcher_OnNewRequest(DatabaseWatcher sender, DataRow newRow)
        {
            var requestId = ((PracticeDataSet.RequestsRow)newRow).requestID;
            var requestRow = (PracticeDataSet.RequestsRow)RequestsTableAdapter.GetRequestById(requestId).Rows[0];
            var clientFio = PracticeDataSet.USERS.FindByuserID(requestRow.clientID).fio;
            var message = $"Клиент {clientFio} добавил в систему новую заявку # {requestId}";
            ShowNotification(message);
        }

        private void ClientWatcher_OnRequestAbsent(DatabaseWatcher sender, DataRow newRow)
        {
            var requestId = ((PracticeDataSet.RequestsRow)newRow).requestID;
            var requestDB = RequestsTableAdapter.GetRequestById(requestId);
            if (requestDB == null || requestDB.Rows.Count == 0)
            {
                var message = $"Заявка # {requestId} удалена из системы.";
                ShowNotification(message);
            }
            else
            {
                var requestRow = (PracticeDataSet.RequestsRow)requestDB.Rows[0];
                if (!requestRow.IscomplectionDateNull())
                {
                    var message = $"Появились новости по заказу номер {requestId}.\nЗаказ готов к выдаче.";
                    ShowNotification(message);
                }
            }
        }

        private void ShowNotification(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>((msg) => MessageBox.Show(this, msg, "Обновление по заказу", MessageBoxButtons.OK, MessageBoxIcon.Information)), message);
            }
            else
            {
                MessageBox.Show(this, message, "Обновление по заказу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}