using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView
{
    public partial class RequestsForm : Form
    {
        private readonly PracticeDataSet.USERSRow CurrentUser;
        private readonly bool showExecutableTime;
        private DataView requestDataView;

        public RequestsForm(PracticeDataSet.USERSRow currentUser)
        {
            CurrentUser = currentUser;
            InitializeComponent();
            var role = (RoleType)currentUser.type;
            ChangeDescription.Enabled = role == RoleType.Client || role == RoleType.Manager;
            SetMaster.Enabled = role == RoleType.Operator || role == RoleType.Manager;
            FindRequest.Enabled = role != RoleType.Client;
            Parts.Enabled = role == RoleType.Manager || role == RoleType.Master;
            showExecutableTime = role != RoleType.Client;
            ExecutionTimeColumn.Visible = AverageTime.Visible = AverageTimeLabel.Visible = showExecutableTime;
            Comment.ReadOnly = role != RoleType.Manager && role != RoleType.Master;
            ChangeStatus.Enabled = role == RoleType.Manager || role == RoleType.Master;
            DeleteRequest.Enabled = role == RoleType.Manager;

            PracticeDataSet.Requests.Columns.Add("LowerDescription", typeof(string));
            PracticeDataSet.Requests.Columns.Add("LowerStatus", typeof(string));

            UserName.Text = currentUser.fio;
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            RequestGrid.DataSource = null;
            CommentsTableAdapter.Fill(PracticeDataSet.Comments);
            switch ((RoleType)CurrentUser.type)
            {
                case RoleType.Client:
                    ClientColumn.Visible = false;
                    RequestsTableAdapter.FillByClient(PracticeDataSet.Requests, CurrentUser.userID);
                    break;

                case RoleType.Master:
                    MasterColumn.Visible = false;
                    RequestsTableAdapter.FillByMaster(PracticeDataSet.Requests, CurrentUser.userID);
                    break;

                default:
                    RequestsTableAdapter.FillExt(PracticeDataSet.Requests);
                    break;
            }
            foreach(var rawData in PracticeDataSet.Requests)
            {
                rawData["LowerDescription"] = rawData.problemDescryption.ToLower();
                rawData["LowerStatus"] = rawData.requestStatus.ToLower();
            }
            requestDataView = new DataView(PracticeDataSet.Requests);
            RequestGrid.DataSource = requestDataView;

            RefreshView();

            RoleLabel.Text = TypeTableAdapter.GetData().FindBytypeID(CurrentUser.type).role;
        }

        private void RefreshView()
        {
            if (showExecutableTime)
            {
                double summDays = 0;
                int completedCount = 0;
                foreach (DataGridViewRow row in RequestGrid.Rows)
                {
                    var duration = row.Cells["ExecutionTimeColumn"].Value.ToString();
                    if (duration.Length > 0)
                    {
                        summDays += int.Parse(duration);
                        completedCount++;
                    }
                }

                AverageTime.Text = completedCount > 0
                    ? (summDays / completedCount).ToString("F0")
                    : "<нет>";
            }

            Comment.Enabled = requestDataView.Count > 0;

            TotalRequest.Text = RequestsTableAdapter.GetTotalCount().ToString();
            RequestCount.Text = requestDataView.Count.ToString();
            RequestGrid.Refresh();
        }

        private PracticeDataSet.RequestsRow GetCurrentRow()
        {
            var sel = RequestGrid.CurrentRow;
            if (sel == null)
                return null;

            var index = sel.Index;
            return (PracticeDataSet.RequestsRow)requestDataView[index].Row;
        }

        private void ChangeDescription_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if(row == null) 
                return;

            var inputText = new InputTextForm();
            inputText.Caption = "Изменить описание проблемы";
            inputText.Label = "Описание проблемы:";
            inputText.InputText = row.problemDescryption;

            if (inputText.ShowDialog() == DialogResult.OK)
            {
                row.problemDescryption = inputText.InputText;
                row["LowerDescription"] = inputText.InputText.ToLower();
                RequestsTableAdapter.Update(row);
                RefreshView();
            }
        }

        private void FindRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(requestDataView.RowFilter))
            { 
                var findForm = new FindRequestForm((RoleType)CurrentUser.type == RoleType.Client);
                if (findForm.ShowDialog() != DialogResult.OK)
                    return;

                requestDataView.RowFilter = findForm.GetFilter();
                FindRequest.Text = "Сбросить фильтр";

                if (requestDataView.Count == 0)
                {
                    MessageBox.Show(this, "Поиск по заданным критериям не дал результатов. Попробуйте изменить критерии поиска.",
                        "Пустой результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                requestDataView.RowFilter = "";
                FindRequest.Text = "Найти заявку";
            }
            RefreshView();
        }

        private void SetMaster_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
                return;

            if (row.IscomplectionDateNull())
            {
                var form = new SelectUserForm(RoleType.Master, row.IsmasterIDNull() ? 0 : row.masterID);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    row.masterID = form.SelectedUserID;
                    row["MasterFio"] = UsersTableAdapter.GetData().FindByuserID(form.SelectedUserID).fio;

                    RequestsTableAdapter.Update(row);
                    RefreshView();
                }
            }
            else
            {
                MessageBox.Show(this, "Заявка уже закрыта, назначить мастера нельзя.", "Ошибка назначения мастера", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void Parts_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
                return;

            var inputText = new InputTextForm();
            inputText.Caption = "Требуемые запчасти";
            inputText.Label = "Укажите сведения о требуемых запчастях:";
            inputText.InputText = row.repairParts;

            if (inputText.ShowDialog() == DialogResult.OK)
            {
                row.repairParts = inputText.InputText;
                RequestsTableAdapter.Update(row);
                RefreshView();
            }
        }

        private void ChangeStatus_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
                return;

            if (!row.IscomplectionDateNull())
            {
                MessageBox.Show(this, "Изменить статус завершенной заявки нельзя", "Ошибка изменения статуса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var form = new StatusForm();
                form.Status = row.requestStatus;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    row.requestStatus = form.Status;
                    row["LowerStatus"] = form.Status.ToLower();
                    if (form.IsFinished)
                    {
                        row.complectionDate = DateTime.Now.Date;
                        row["Duration"] = (row.complectionDate - row.startDate).TotalDays.ToString();
                    }
                    RequestsTableAdapter.Update(row);
                    RefreshView();
                }
            }
        }

        private void RequestGrid_SelectionChanged(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
            {
                Comment.Text = "";
            }
            else
            {
                var comment = PracticeDataSet.Comments.FirstOrDefault(c => c.requestID == row.requestID);
                if (comment == null)
                    Comment.Text = "";
                else
                    Comment.Text = comment.message;
            }
        }

        private void Comment_Leave(object sender, EventArgs e)
        {
            var requestRow = GetCurrentRow();
            var commentRow = PracticeDataSet.Comments.FirstOrDefault(c => c.requestID == requestRow.requestID);
            if (commentRow == null)
            {
                if (Comment.Text.Length > 0)
                {
                    CommentsTableAdapter.Insert(Comment.Text, requestRow.requestID);
                    CommentsTableAdapter.Fill(PracticeDataSet.Comments);
                }
            }
            else
            {
                commentRow.message = Comment.Text;
                CommentsTableAdapter.Update(commentRow);
            }
        }

        private void DeleteRequest_Click(object sender, EventArgs e)
        {
            var requestRow = GetCurrentRow();
            if (requestRow == null)
            {
                MessageBox.Show(this, "Необходимо выделить в списке заявку, которую следует удалить.",
                    "Ошибка удаления заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(this, $"Вы действительно хотите удалить заявку #{requestRow.requestID}, заведенную клентом '{requestRow["ClientFio"]}'" +
                $" {requestRow.startDate.ToString("dd-MM-yyyy")}? Восстановить заявку после удаления будет невозможно!",
                "Удалить заявку", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            RequestsTableAdapter.DeleteById(requestRow.requestID);
            PracticeDataSet.Requests.RemoveRequestsRow(requestRow);
            RefreshView();
        }
    }
}
