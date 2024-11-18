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
    public partial class LoginForm : Form
    {
        private Random random = new Random();
        private const int captchaLength = 6;
        private int tryCount = 0;
        private PracticeDataSet.USERSRow loggedIn = null;

        private PracticeDataSet.USERSDataTable users = null;

        public LoginForm()
        {
            InitializeComponent();
            ReEnableOk.Interval = 3 * 60 * 1000;
        }

        public PracticeDataSet.USERSDataTable Users
        {
            set { users = value; }
        }

        public PracticeDataSet.USERSRow User
        {
            get { return loggedIn; }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                InitializeCapcha();
                if (tryCount++ > 1)
                {
                    Ok.Enabled = false;
                    if(tryCount == 3)
                    {
                        ReEnableOk.Start();
                    }
                }
            }
        }

        private bool CheckInput()
        {
            var expectedUser = users.FirstOrDefault(u => u.login == Login.Text);
            bool result;
            if ((!Capcha.Visible || CheckCapcha()) && CheckPassword())
            {
                DialogResult = DialogResult.OK;
                tryCount = 0;
                Close();
                result = true;
            }
            else
            {
                MessageBox.Show(this, tryCount >= 3 ? "Вход запрещен" : "Повторите вход", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            EnterLogTableAdapter.InsertEnter(expectedUser?.userID, Login.Text, result);
            return result;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = ShowPassword.Checked ? '\0' : '*';
        }

        private void InitializeCapcha()
        {
            Capcha.Visible = CapchaLabel.Visible = CapchaText.Visible = RegenerateCapcha.Visible = true;
            CapchaText.Text = string.Empty;

            var text = GenerateRandomText();
            Capcha.Tag = text;

            var bitmap = new Bitmap(Capcha.Width, Capcha.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    var dx = Capcha.Width / captchaLength;
                    int x = 0;
                    foreach (char c in text)
                    {
                        g.DrawString($"{c}", font, Brushes.Black, x, random.Next(0, Capcha.Height / 2));
                        x += dx;
                    }
                }
                Pen pen = new Pen(Color.LightGray, 3);
                for (int i = 0; i < 5; i++)
                {
                    g.DrawLine(pen, random.Next(0, Capcha.Width), random.Next(0, Capcha.Height), random.Next(0, Capcha.Width), random.Next(0, Capcha.Height));
                }
            }
            Capcha.Image = bitmap;
        }

        private string GenerateRandomText()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] text = new char[captchaLength];
            for (int i = 0; i < captchaLength; i++)
            {
                text[i] = chars[random.Next(chars.Length)];
            }
            return new string(text);
        }

        private bool CheckCapcha()
        {
            if (!Capcha.Visible)
            {
                return true;
            }

            return (string)Capcha.Tag == CapchaText.Text.ToUpper();
        }

        private bool CheckPassword()
        {
            loggedIn = users == null ? null : users.FirstOrDefault(u => u.login == Login.Text && u.password == Password.Text);
            return loggedIn != null;
        }

        private void RegenerateCapcha_Click(object sender, EventArgs e)
        {
            InitializeCapcha();
        }

        private void ReEnableOk_Tick(object sender, EventArgs e)
        {
            ReEnableOk.Stop();
            Ok.Enabled = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (tryCount == 0)
            {
                Capcha.Visible = CapchaLabel.Visible = CapchaText.Visible = RegenerateCapcha.Visible = false;
            }
            else
            {
                InitializeCapcha();
            }
            Login.Text = "";
            Password.Text = "";
            CapchaText.Text = "";
            ShowPassword.Checked = false;
        }
    }
}
