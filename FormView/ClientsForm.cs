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
    public partial class ClientsForm : Form
    {
        private readonly int currentUser;
        private readonly RoleType allowedRole;
        private readonly ImageLoader photo;

        public ClientsForm(RoleType allowedRole, int currentUser)
        {
            InitializeComponent();
            photo = new ImageLoader(Photo, PhotoLoadingError);

            this.allowedRole = allowedRole;
            this.currentUser = currentUser;
            RoleColumn.Visible = allowedRole == RoleType.None;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            if (allowedRole == RoleType.None)
                UsersTableAdapter.FillExt(PracticeDataSet.USERS);
            else
                UsersTableAdapter.FillExtByType(PracticeDataSet.USERS, (int)allowedRole);
        }

        private PracticeDataSet.USERSRow GetCurrentRow()
        {
            var curRowView = (DataRowView)UsersBindingSource.Current;
            return (PracticeDataSet.USERSRow)curRowView?.Row;
        }

        private void UserGridView_SelectionChanged(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null) 
                photo.ResetImage();
            else
                photo.LoadImage(row.IsphotoNull() ? null : row.photo);
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            var form = new AddEditUserForm(allowedRole == RoleType.Client);
            string userType = allowedRole == RoleType.Client ? "клиента" : "пользователя";
            form.Text = $"Добавить {userType}";
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show(this, $"Добавить нового {userType} {form.Fio} с ролью '{form.RoleText}'?", $"Добавление {userType}",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsersTableAdapter.Insert(form.Fio, form.Phone, form.Login, form.Password, (int)form.Role, form.Photo);
                    ClientsForm_Load(null, null);
                }
            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
            {
                MessageBox.Show(this, "Чтобы изменить пользователя, нужно выделить его в списке.",
                    "Ошибка изменения пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userType = allowedRole == RoleType.Client ? "клиента" : "пользователя";
            var form = new AddEditUserForm(allowedRole == RoleType.Client)
            {
                Text = $"Изменить {userType}",
                Fio = row.fio,
                Role = (RoleType)row.type,
                Phone = row.phone,
                Login = row.login,
                Password = row.password,
                EditedUserId = row.userID,
            };
            if (!row.IsphotoNull())
                form.Photo = row.photo;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show(this, $"Изменить свойства {userType} {form.Fio}?", $"Изменение {userType}",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    row.fio = form.Fio;
                    row.phone = form.Phone;
                    row.login = form.Login;
                    row.password = form.Password;
                    if (form.Photo.Length == 0)
                        row.SetphotoNull();
                    else
                        row.photo = form.Photo;
                    row.type = (int)form.Role;
                    row["role"] = TypeTableAdapter.GetData().FindBytypeID((int)form.Role).role;

                    UsersTableAdapter.Update(row);
                    UserGridView.Refresh();
                    UserGridView_SelectionChanged(null, null);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
            {
                MessageBox.Show(this, "Чтобы удалить пользователя, нужно выделить его в списке.",
                    "Ошибка удаления пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (row.userID == currentUser)
            {
                MessageBox.Show(this, "Нельзя удалить текущего пользователя.", "Ошибка удаления пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(this, $"Вы действительно хотите безвозвратно удалить пользователя {row.fio}?",
                "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var table = UsersTableAdapter.GetData();
                var deletingRow = table.First(x => x.userID == row.userID);
                deletingRow.Delete();
                UsersTableAdapter.Update(table);

                PracticeDataSet.USERS.RemoveUSERSRow(row);
                UserGridView.Refresh();
            }
            catch(SqlException)
            {
                MessageBox.Show(this, $"Невозможно удалить пользователя {row.fio}, так как он фигурирует в заказах.",
                    "Ошибка удаления пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
