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
    public partial class OngoingTechForm : Form
    {
        public OngoingTechForm()
        {
            InitializeComponent();
        }

        private void OngoingTechForm_Load(object sender, EventArgs e)
        {
            OrgTechModelTableAdapter.FillOngoing(PracticeDataSet.orgTechModel);
        }
    }
}
