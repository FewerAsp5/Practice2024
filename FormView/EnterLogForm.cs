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
    public partial class EnterLogForm : Form
    {
        private DataView LoginDataView = null;

        public EnterLogForm()
        {
            InitializeComponent();
        }

        private void EnterLogForm_Load(object sender, EventArgs e)
        {
            EnterLogTableAdapter.FillWithUserName(PracticeDataSet.EnterLog);
            LoginDataView = new DataView(PracticeDataSet.EnterLog);
            EnterLogGridView.DataSource = LoginDataView;
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (LoginDataView.RowFilter.Length == 0)
            {
                var form = new FilterLoginForm();
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoginDataView.RowFilter = "UserLogin " + form.Filter;
                    Filter.Text = "Убрать фильтр";

                    if (LoginDataView.Count == 0)
                    {
                        MessageBox.Show(this, "Поиск по заданным критериям не дал результатов. Попробуйте изменить критерии поиска.",
                            "Пустой результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                LoginDataView.RowFilter = string.Empty;
                Filter.Text = "Отфильтровать по логину";
            }
        }
    }
}