namespace FormView
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Capcha = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.CapchaLabel = new System.Windows.Forms.Label();
            this.CapchaText = new System.Windows.Forms.TextBox();
            this.RegenerateCapcha = new System.Windows.Forms.Button();
            this.ReEnableOk = new System.Windows.Forms.Timer(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.EnterLogTableAdapter = new FormView.PracticeDataSetTableAdapters.EnterLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Capcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 25);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(235, 20);
            this.Login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 64);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(235, 20);
            this.Password.TabIndex = 3;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 241);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Capcha
            // 
            this.Capcha.BackColor = System.Drawing.Color.White;
            this.Capcha.Location = new System.Drawing.Point(12, 113);
            this.Capcha.Name = "Capcha";
            this.Capcha.Size = new System.Drawing.Size(235, 76);
            this.Capcha.TabIndex = 5;
            this.Capcha.TabStop = false;
            this.Capcha.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(172, 241);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(12, 90);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(128, 17);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "Показывать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // CapchaLabel
            // 
            this.CapchaLabel.AutoSize = true;
            this.CapchaLabel.Location = new System.Drawing.Point(9, 192);
            this.CapchaLabel.Name = "CapchaLabel";
            this.CapchaLabel.Size = new System.Drawing.Size(154, 13);
            this.CapchaLabel.TabIndex = 8;
            this.CapchaLabel.Text = "Введите символы с рисунка:";
            this.CapchaLabel.Visible = false;
            // 
            // CapchaText
            // 
            this.CapchaText.Location = new System.Drawing.Point(12, 208);
            this.CapchaText.Name = "CapchaText";
            this.CapchaText.Size = new System.Drawing.Size(108, 20);
            this.CapchaText.TabIndex = 9;
            this.CapchaText.Visible = false;
            // 
            // RegenerateCapcha
            // 
            this.RegenerateCapcha.Location = new System.Drawing.Point(126, 206);
            this.RegenerateCapcha.Name = "RegenerateCapcha";
            this.RegenerateCapcha.Size = new System.Drawing.Size(122, 23);
            this.RegenerateCapcha.TabIndex = 10;
            this.RegenerateCapcha.Text = "Перегенирировать";
            this.RegenerateCapcha.UseVisualStyleBackColor = true;
            this.RegenerateCapcha.Visible = false;
            this.RegenerateCapcha.Click += new System.EventHandler(this.RegenerateCapcha_Click);
            // 
            // ReEnableOk
            // 
            this.ReEnableOk.Tick += new System.EventHandler(this.ReEnableOk_Tick);
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EnterLogTableAdapter
            // 
            this.EnterLogTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(260, 272);
            this.Controls.Add(this.RegenerateCapcha);
            this.Controls.Add(this.CapchaText);
            this.Controls.Add(this.CapchaLabel);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Capcha);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Capcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.PictureBox Capcha;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label CapchaLabel;
        private System.Windows.Forms.TextBox CapchaText;
        private System.Windows.Forms.Button RegenerateCapcha;
        private System.Windows.Forms.Timer ReEnableOk;
        private PracticeDataSet PracticeDataSet;
        private PracticeDataSetTableAdapters.EnterLogTableAdapter EnterLogTableAdapter;
    }
}