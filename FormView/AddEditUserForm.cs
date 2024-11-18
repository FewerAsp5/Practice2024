using PracticeTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView
{
    public partial class AddEditUserForm : Form
    {
        private readonly ImageLoader photo;
        private int editedUserId = 0;
        RoleType initialRole;

        public AddEditUserForm(bool clientOnly)
        {
            InitializeComponent();
            RoleComboBox.Visible = RoleLabel.Visible = !clientOnly;

            photo = new ImageLoader(PhotoBox, PhotoLoadingError);
        }

        public int EditedUserId
        {
            set => editedUserId = value;
        }

        public string Fio
        { 
            get => FullName.Text;
            set => FullName.Text = value;
        }

        public string RoleText
        { get => RoleComboBox.Text; }

        public RoleType Role
        {
            get { return (RoleType)((int?)RoleComboBox.SelectedValue ?? 0); }
            set
            {
                if (RoleComboBox.Visible)
                    RoleComboBox.SelectedValue = (int)value;
                else
                    initialRole = value;
            }
        }

        public string Phone
        {
            get { return PhoneNumber.Text; }
            set { PhoneNumber.Text = value; }
        }

        public string Login
        {
            get { return LoginTextBox.Text; }
            set { LoginTextBox.Text = value; }
        }

        public string Password
        {
            get { return Password1.Text; }
            set
            {
                Password1.Text = Password2.Text = value;
                ShowPassword.Checked = false;
                ShowPassword.Enabled = false;
            }
        }

        public string Photo
        {
            get { return PhotoPath.Text; }
            set 
            { 
                PhotoPath.Text = value;
                RedrawPhoto();
            }
        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            TypeTableAdapter.Fill(this.PracticeDataSet.TYPE);
            if (!RoleComboBox.Visible)
                RoleComboBox.SelectedValue = (int)RoleType.Client;
            else
                RoleComboBox.SelectedValue = (int)initialRole;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            Password1.PasswordChar = Password2.PasswordChar = ShowPassword.Checked ? '\0' : '*';
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (OpenFhotoDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoPath.Text = OpenFhotoDialog.FileName;
                RedrawPhoto();
            }
        }

        private void PhotoPath_Leave(object sender, EventArgs e)
        {
            RedrawPhoto();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (string.IsNullOrWhiteSpace(Password1.Text))
            {
                if (MessageBox.Show(this, "Пароль не может быть пустым. Повторите ввод.", "Ошибка назначения пароля",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }
            else if (Password1.Text != Password2.Text)
            {
                if (MessageBox.Show(this, "Пароли не совпадают. Повторите ввод.", "Ошибка назначения пароля",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }
            else if (string.IsNullOrWhiteSpace(FullName.Text))
            {
                if (MessageBox.Show(this, "Ф. И. О. не может быть пустым. Повторите ввод.", "Ошибка ввода Ф. И. О.", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error) == DialogResult.OK)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }
            else if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                if (MessageBox.Show(this, "Логин не может быть пустым. Повторите ввод.", "Ошибка назначения логина",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }
            else if (UsersTableAdapter.GetData().Any(u => u.login.ToLower() == LoginTextBox.Text.ToLower() && u.userID != editedUserId))
            {
                if (MessageBox.Show(this, $"Логин {LoginTextBox.Text} уже занят. Повторите ввод.",
                    "Ошибка назначения логина", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }

            Close();
        }

        private void RedrawPhoto()
        {
            if (string.IsNullOrWhiteSpace(PhotoPath.Text))
                photo.ResetImage();
            else
                photo.LoadImage(PhotoPath.Text);
        }
    }
}
