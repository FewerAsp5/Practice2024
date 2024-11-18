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
    public partial class FilterLoginForm : Form
    {
        public FilterLoginForm()
        {
            InitializeComponent();
            UserSelect.Checked = true;
        }

        public string Filter
        {
            get
            {
                if (UserSelect.Checked)
                {
                    return $" = '{(string)UserComboBox.SelectedValue}'";
                }
                else
                {
                    return $" LIKE '*{LoginTextBox.Text}*'";
                }
            }
        }

        private void SelectUserForm_Load(object sender, EventArgs e)
        {
            UsersTableAdapter.Fill(PracticeDataSet.USERS);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (LoginSelect.Checked && LoginTextBox.Text.Length == 0)
            {
                var yesno = MessageBox.Show(this, "Нужно указать искомый логин или его фрагмент, или выбрать зарегистрированного пользователя из списка. Продолжить?",
                    "Ошибка ввода", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (yesno == DialogResult.Yes)
                {
                    return;
                }
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void UserSelect_CheckedChanged(object sender, EventArgs e)
        {
            bool user = sender == UserSelect;
            UserComboBox.Enabled = user;
            LoginTextBox.Enabled = !user;
        }
    }
}
