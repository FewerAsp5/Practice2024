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
    public partial class NewOrderForm : Form
    {
        private readonly int currentClientId;
        public NewOrderForm(PracticeDataSet.USERSRow currentUser)
        {
            InitializeComponent();

            currentClientId = (RoleType)currentUser.type == RoleType.Client ? currentUser.userID : 0;
            ClientList.Enabled = currentClientId == 0;
        }

        public string Description
        { get => ProblemDescr.Text; }

        public int TechType
        { get => (int)ModelType.SelectedValue; }

        public string TechName
        { get => ModelName.Text; }

        public int Client
        { get => (int)ClientList.SelectedValue; }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            UsersTableAdapter.FillByType(PracticeDataSet.USERS, (int)RoleType.Client);
            if (currentClientId != 0)
            {
                ClientList.SelectedValue = currentClientId;
            }
            TechTypeTableAdapter.Fill(PracticeDataSet.TechType);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (Description.Length == 0)
            {
                MessageBox.Show(this, "Необходимо ввести описание проблемы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TechName.Length == 0)
            {
                MessageBox.Show(this, "Необходимо указать модель устройства.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
