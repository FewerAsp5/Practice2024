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
    public partial class InputTextForm : Form
    {
        public InputTextForm()
        {
            InitializeComponent();
        }

        public string Caption
        {
            set { Text = value; }
        }

        public string Label
        {
            set { LabelControl.Text = value; }
        }

        public string InputText
        {
            set { TextControl.Text = value; }
            get { return TextControl.Text; }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
