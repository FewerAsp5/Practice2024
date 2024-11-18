namespace FormView
{
    partial class MainForm
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
            this.LoginLogout = new System.Windows.Forms.Button();
            this.CurrentUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.TextBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhotoLoadingError = new System.Windows.Forms.Label();
            this.Requests = new System.Windows.Forms.Button();
            this.NewRequest = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.AllUsers = new System.Windows.Forms.Button();
            this.OngoingTech = new System.Windows.Forms.Button();
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            this.TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypeTableAdapter = new FormView.PracticeDataSetTableAdapters.TYPETableAdapter();
            this.OrgTechModelTableAdapter = new FormView.PracticeDataSetTableAdapters.orgTechModelTableAdapter();
            this.RequestsTableAdapter = new FormView.PracticeDataSetTableAdapters.RequestsTableAdapter();
            this.EnterLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь:";
            // 
            // LoginLogout
            // 
            this.LoginLogout.Location = new System.Drawing.Point(627, 23);
            this.LoginLogout.Name = "LoginLogout";
            this.LoginLogout.Size = new System.Drawing.Size(161, 23);
            this.LoginLogout.TabIndex = 2;
            this.LoginLogout.Text = "Войти";
            this.LoginLogout.UseVisualStyleBackColor = true;
            this.LoginLogout.Click += new System.EventHandler(this.LoginLogout_Click);
            // 
            // CurrentUser
            // 
            this.CurrentUser.Location = new System.Drawing.Point(12, 25);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.ReadOnly = true;
            this.CurrentUser.Size = new System.Drawing.Size(609, 20);
            this.CurrentUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Роль:";
            // 
            // Role
            // 
            this.Role.Location = new System.Drawing.Point(12, 64);
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Size = new System.Drawing.Size(100, 20);
            this.Role.TabIndex = 5;
            // 
            // Photo
            // 
            this.Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo.Location = new System.Drawing.Point(12, 103);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(100, 111);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 6;
            this.Photo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фото:";
            // 
            // PhotoLoadingError
            // 
            this.PhotoLoadingError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoLoadingError.Location = new System.Drawing.Point(12, 103);
            this.PhotoLoadingError.Name = "PhotoLoadingError";
            this.PhotoLoadingError.Size = new System.Drawing.Size(100, 23);
            this.PhotoLoadingError.TabIndex = 8;
            this.PhotoLoadingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhotoLoadingError.UseCompatibleTextRendering = true;
            this.PhotoLoadingError.Visible = false;
            // 
            // Requests
            // 
            this.Requests.Enabled = false;
            this.Requests.Location = new System.Drawing.Point(12, 248);
            this.Requests.Name = "Requests";
            this.Requests.Size = new System.Drawing.Size(100, 23);
            this.Requests.TabIndex = 9;
            this.Requests.Text = "Заявки";
            this.Requests.UseVisualStyleBackColor = true;
            this.Requests.Click += new System.EventHandler(this.Requests_Click);
            // 
            // NewRequest
            // 
            this.NewRequest.Enabled = false;
            this.NewRequest.Location = new System.Drawing.Point(118, 248);
            this.NewRequest.Name = "NewRequest";
            this.NewRequest.Size = new System.Drawing.Size(100, 23);
            this.NewRequest.TabIndex = 10;
            this.NewRequest.Text = "Новая заявка";
            this.NewRequest.UseVisualStyleBackColor = true;
            this.NewRequest.Click += new System.EventHandler(this.NewRequest_Click);
            // 
            // Clients
            // 
            this.Clients.Enabled = false;
            this.Clients.Location = new System.Drawing.Point(224, 248);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(100, 23);
            this.Clients.TabIndex = 11;
            this.Clients.Text = "Заказчики";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // AllUsers
            // 
            this.AllUsers.Enabled = false;
            this.AllUsers.Location = new System.Drawing.Point(330, 248);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(100, 23);
            this.AllUsers.TabIndex = 12;
            this.AllUsers.Text = "Пользователи";
            this.AllUsers.UseVisualStyleBackColor = true;
            this.AllUsers.Click += new System.EventHandler(this.AllUsers_Click);
            // 
            // OngoingTech
            // 
            this.OngoingTech.Location = new System.Drawing.Point(436, 248);
            this.OngoingTech.Name = "OngoingTech";
            this.OngoingTech.Size = new System.Drawing.Size(129, 23);
            this.OngoingTech.TabIndex = 13;
            this.OngoingTech.Text = "Техника в ремонте";
            this.OngoingTech.UseVisualStyleBackColor = true;
            this.OngoingTech.Click += new System.EventHandler(this.OngoingTech_Click);
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "USERS";
            this.UsersBindingSource.DataSource = this.PracticeDataSet;
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // TypeBindingSource
            // 
            this.TypeBindingSource.DataMember = "TYPE";
            this.TypeBindingSource.DataSource = this.PracticeDataSet;
            // 
            // TypeTableAdapter
            // 
            this.TypeTableAdapter.ClearBeforeFill = true;
            // 
            // OrgTechModelTableAdapter
            // 
            this.OrgTechModelTableAdapter.ClearBeforeFill = true;
            // 
            // RequestsTableAdapter
            // 
            this.RequestsTableAdapter.ClearBeforeFill = true;
            // 
            // EnterLog
            // 
            this.EnterLog.Enabled = false;
            this.EnterLog.Location = new System.Drawing.Point(571, 248);
            this.EnterLog.Name = "EnterLog";
            this.EnterLog.Size = new System.Drawing.Size(100, 23);
            this.EnterLog.TabIndex = 14;
            this.EnterLog.Text = "История входа";
            this.EnterLog.UseVisualStyleBackColor = true;
            this.EnterLog.Click += new System.EventHandler(this.EnterLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterLog);
            this.Controls.Add(this.OngoingTech);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.NewRequest);
            this.Controls.Add(this.Requests);
            this.Controls.Add(this.PhotoLoadingError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentUser);
            this.Controls.Add(this.LoginLogout);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Бюро ремонта";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginLogout;
        private System.Windows.Forms.TextBox CurrentUser;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Role;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhotoLoadingError;
        private System.Windows.Forms.BindingSource TypeBindingSource;
        private PracticeDataSetTableAdapters.TYPETableAdapter TypeTableAdapter;
        private System.Windows.Forms.Button Requests;
        private System.Windows.Forms.Button NewRequest;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button AllUsers;
        private PracticeDataSetTableAdapters.orgTechModelTableAdapter OrgTechModelTableAdapter;
        private PracticeDataSetTableAdapters.RequestsTableAdapter RequestsTableAdapter;
        private System.Windows.Forms.Button OngoingTech;
        private System.Windows.Forms.Button EnterLog;
    }
}

