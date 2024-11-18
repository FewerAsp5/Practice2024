namespace FormView
{
    partial class ClientsForm
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
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.UserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.PhotoLoadingError = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.TypeTableAdapter = new FormView.PracticeDataSetTableAdapters.TYPETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGridView
            // 
            this.UserGridView.AllowUserToAddRows = false;
            this.UserGridView.AllowUserToDeleteRows = false;
            this.UserGridView.AutoGenerateColumns = false;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDDataGridViewTextBoxColumn,
            this.FioDataGridViewTextBoxColumn,
            this.PhoneDataGridViewTextBoxColumn,
            this.LoginDataGridViewTextBoxColumn,
            this.RoleColumn,
            this.PasswordDataGridViewTextBoxColumn,
            this.PhotoDataGridViewTextBoxColumn});
            this.UserGridView.DataSource = this.UsersBindingSource;
            this.UserGridView.Location = new System.Drawing.Point(12, 25);
            this.UserGridView.MultiSelect = false;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RowHeadersVisible = false;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(739, 266);
            this.UserGridView.TabIndex = 0;
            this.UserGridView.SelectionChanged += new System.EventHandler(this.UserGridView_SelectionChanged);
            // 
            // UserIDDataGridViewTextBoxColumn
            // 
            this.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.UserIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn";
            this.UserIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.UserIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // FioDataGridViewTextBoxColumn
            // 
            this.FioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.FioDataGridViewTextBoxColumn.HeaderText = "Фамилия Имя Отчество";
            this.FioDataGridViewTextBoxColumn.Name = "FioDataGridViewTextBoxColumn";
            this.FioDataGridViewTextBoxColumn.ReadOnly = true;
            this.FioDataGridViewTextBoxColumn.Width = 300;
            // 
            // PhoneDataGridViewTextBoxColumn
            // 
            this.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.PhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn";
            this.PhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.PhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // LoginDataGridViewTextBoxColumn
            // 
            this.LoginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.LoginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.LoginDataGridViewTextBoxColumn.Name = "LoginDataGridViewTextBoxColumn";
            this.LoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RoleColumn
            // 
            this.RoleColumn.DataPropertyName = "role";
            this.RoleColumn.HeaderText = "Роль";
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            // 
            // PasswordDataGridViewTextBoxColumn
            // 
            this.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.PasswordDataGridViewTextBoxColumn.HeaderText = "password";
            this.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn";
            this.PasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.PasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // PhotoDataGridViewTextBoxColumn
            // 
            this.PhotoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.PhotoDataGridViewTextBoxColumn.HeaderText = "photo";
            this.PhotoDataGridViewTextBoxColumn.Name = "PhotoDataGridViewTextBoxColumn";
            this.PhotoDataGridViewTextBoxColumn.ReadOnly = true;
            this.PhotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "USERS";
            this.UsersBindingSource.DataSource = this.PracticeDataSet;
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список пользователей:";
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(520, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // PhotoLoadingError
            // 
            this.PhotoLoadingError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoLoadingError.Location = new System.Drawing.Point(12, 297);
            this.PhotoLoadingError.Name = "PhotoLoadingError";
            this.PhotoLoadingError.Size = new System.Drawing.Size(100, 23);
            this.PhotoLoadingError.TabIndex = 10;
            this.PhotoLoadingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhotoLoadingError.UseCompatibleTextRendering = true;
            this.PhotoLoadingError.Visible = false;
            // 
            // Photo
            // 
            this.Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo.Location = new System.Drawing.Point(12, 297);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(100, 111);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 9;
            this.Photo.TabStop = false;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(142, 297);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(150, 23);
            this.AddUser.TabIndex = 11;
            this.AddUser.Text = "Добавить пользователя";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(298, 297);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(150, 23);
            this.EditUser.TabIndex = 12;
            this.EditUser.Text = "Изменить пользователя";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(454, 297);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Удалить пользователя";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // TypeTableAdapter
            // 
            this.TypeTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.PhotoLoadingError);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserGridView);
            this.Name = "ClientsForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserGridView;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label PhotoLoadingError;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Delete;
        private PracticeDataSetTableAdapters.TYPETableAdapter TypeTableAdapter;
    }
}