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
    public partial class SelectUserForm : Form
    {
        private readonly RoleType roleType;
        private readonly int initialSelectedUser;
        public SelectUserForm(RoleType roleType, int initialSelectedUser)
        {
            InitializeComponent();
            this.roleType = roleType;
            this.initialSelectedUser = initialSelectedUser;
        }

        public int SelectedUserID
        {
            get { return (int?)UserComboBox.SelectedValue ?? 0; }
        }

        private void SelectUserForm_Load(object sender, EventArgs e)
        {
            if (roleType == RoleType.None)
            {
                UsersTableAdapter.Fill(PracticeDataSet.USERS);
            }
            else
            {
                UsersTableAdapter.FillByType(PracticeDataSet.USERS, (int)roleType);
            }
            if (initialSelectedUser != 0)
            {
                UserComboBox.SelectedValue = initialSelectedUser;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}