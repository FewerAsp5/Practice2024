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
    public partial class FindRequestForm : Form
    {
        private readonly RoleType filteredRole;
        private DateTime parsedStartDate;

        public FindRequestForm(bool filterByMaster)
        {
            InitializeComponent();
            filteredRole = filterByMaster ? RoleType.Master : RoleType.Client;

            if (filteredRole == RoleType.Master)
            {
                FilterByUser.Text = "Мастер:";
            }
        }

        public string GetFilter()
        {
            List<string> where = new List<string>();

            int id;
            if (int.TryParse(RequestID.Text, out id))
                where.Add($"requestID = {id}");
            if (CompletedOnlyCheckBox.Checked)
                where.Add("complectionDate IS NOT NULL");
            if (FilterByUser.Checked)
            {
                var rowView = (DataRowView)UserComboBox.SelectedValue;
                var selectedRow = (PracticeDataSet.USERSRow)rowView.Row;
                var columnName = filteredRole == RoleType.Master ? "masterID" : "clientID";
                where.Add($"{columnName} = {selectedRow.userID}");
            }
            if (Description.Text.Length > 0)
                where.Add($"LowerDescription LIKE '*{Description.Text.ToLower()}*'");
            if (Status.Text.Length > 0)
                where.Add($"LowerStatus LIKE '*{Status.Text.ToLower()}*'");
            if (StartDate.Text.Length > 0)
                where.Add($"startDate = '{parsedStartDate}'");

            string res = "";
            if (where.Count > 0)
            {
                res = where[0];
                for (int i = 1; i < where.Count; i++)
                {
                    res += $" AND {where[i]}";
                }
            }

            return res;
        }

        public string StatusFilter
        {
            get { return Status.Text; }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (StartDate.Text.Length > 0 && !DateTime.TryParse(StartDate.Text, out parsedStartDate))
            {
                MessageBox.Show(this, $"Данные, введенные в поле '{StartDateLabel.Text}', не могут быть распознаны как дата.\nПовторите ввод.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FindRequestForm_Load(object sender, EventArgs e)
        {
            if (filteredRole == RoleType.None)
            {
                UsersTableAdapter.Fill(PracticeDataSet.USERS);
            }
            else
            {
                UsersTableAdapter.FillByType(PracticeDataSet.USERS, (int)filteredRole);
            }
        }

        private void FilterByUser_CheckedChanged(object sender, EventArgs e)
        {
            UserComboBox.Enabled = FilterByUser.Checked;
        }
    }
}