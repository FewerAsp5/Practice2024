namespace FormView
{
    partial class AddEditUserForm
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
            this.FullName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.PhotoPath = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.TypeTableAdapter = new FormView.PracticeDataSetTableAdapters.TYPETableAdapter();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.PhotoLoadingError = new System.Windows.Forms.Label();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            this.OpenFhotoDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф. И. О.";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(123, 6);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(281, 20);
            this.FullName.TabIndex = 1;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(123, 32);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(133, 20);
            this.PhoneNumber.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(123, 58);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(133, 20);
            this.LoginTextBox.TabIndex = 3;
            // 
            // Password1
            // 
            this.Password1.Location = new System.Drawing.Point(123, 84);
            this.Password1.Name = "Password1";
            this.Password1.PasswordChar = '*';
            this.Password1.Size = new System.Drawing.Size(133, 20);
            this.Password1.TabIndex = 4;
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(123, 110);
            this.Password2.Name = "Password2";
            this.Password2.PasswordChar = '*';
            this.Password2.Size = new System.Drawing.Size(133, 20);
            this.Password2.TabIndex = 5;
            // 
            // PhotoPath
            // 
            this.PhotoPath.Location = new System.Drawing.Point(123, 136);
            this.PhotoPath.Name = "PhotoPath";
            this.PhotoPath.Size = new System.Drawing.Size(205, 20);
            this.PhotoPath.TabIndex = 6;
            this.PhotoPath.Leave += new System.EventHandler(this.PhotoPath_Leave);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(334, 133);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(70, 23);
            this.Browse.TabIndex = 7;
            this.Browse.Text = "Обзор";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.DataSource = this.TypeBindingSource;
            this.RoleComboBox.DisplayMember = "role";
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(123, 162);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(133, 21);
            this.RoleComboBox.TabIndex = 8;
            this.RoleComboBox.ValueMember = "typeID";
            // 
            // TypeBindingSource
            // 
            this.TypeBindingSource.DataMember = "TYPE";
            this.TypeBindingSource.DataSource = this.PracticeDataSet;
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 220);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(435, 220);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Повтор пароля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Путь к фотографии";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(12, 165);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(32, 13);
            this.RoleLabel.TabIndex = 16;
            this.RoleLabel.Text = "Роль";
            // 
            // TypeTableAdapter
            // 
            this.TypeTableAdapter.ClearBeforeFill = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(290, 87);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(114, 17);
            this.ShowPassword.TabIndex = 17;
            this.ShowPassword.Text = "Показать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // PhotoLoadingError
            // 
            this.PhotoLoadingError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoLoadingError.Location = new System.Drawing.Point(410, 6);
            this.PhotoLoadingError.Name = "PhotoLoadingError";
            this.PhotoLoadingError.Size = new System.Drawing.Size(100, 23);
            this.PhotoLoadingError.TabIndex = 19;
            this.PhotoLoadingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhotoLoadingError.UseCompatibleTextRendering = true;
            this.PhotoLoadingError.Visible = false;
            // 
            // PhotoBox
            // 
            this.PhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoBox.Location = new System.Drawing.Point(410, 6);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(100, 111);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 18;
            this.PhotoBox.TabStop = false;
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // OpenFhotoDialog
            // 
            this.OpenFhotoDialog.Filter = "BMP|*.bmp|JPG|*.jpg|Все файлы|*.*";
            this.OpenFhotoDialog.Title = "Открыть фотографию";
            // 
            // AddEditUserForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(525, 255);
            this.Controls.Add(this.PhotoLoadingError);
            this.Controls.Add(this.PhotoBox);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.PhotoPath);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label1);
            this.Name = "AddEditUserForm";
            this.Text = "AddEditUserForm";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.TextBox PhotoPath;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RoleLabel;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource TypeBindingSource;
        private PracticeDataSetTableAdapters.TYPETableAdapter TypeTableAdapter;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label PhotoLoadingError;
        private System.Windows.Forms.PictureBox PhotoBox;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
        private System.Windows.Forms.OpenFileDialog OpenFhotoDialog;
    }
}