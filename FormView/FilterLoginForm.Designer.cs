namespace FormView
{
    partial class FilterLoginForm
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
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.UserSelect = new System.Windows.Forms.RadioButton();
            this.LoginSelect = new System.Windows.Forms.RadioButton();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.DataSource = this.UsersBindingSource;
            this.UserComboBox.DisplayMember = "fio";
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(15, 41);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(255, 21);
            this.UserComboBox.TabIndex = 1;
            this.UserComboBox.ValueMember = "login";
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
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 152);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(198, 152);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // UserSelect
            // 
            this.UserSelect.AutoSize = true;
            this.UserSelect.Location = new System.Drawing.Point(15, 12);
            this.UserSelect.Name = "UserSelect";
            this.UserSelect.Size = new System.Drawing.Size(98, 17);
            this.UserSelect.TabIndex = 4;
            this.UserSelect.TabStop = true;
            this.UserSelect.Text = "Пользователь";
            this.UserSelect.UseVisualStyleBackColor = true;
            this.UserSelect.CheckedChanged += new System.EventHandler(this.UserSelect_CheckedChanged);
            // 
            // LoginSelect
            // 
            this.LoginSelect.AutoSize = true;
            this.LoginSelect.Location = new System.Drawing.Point(15, 79);
            this.LoginSelect.Name = "LoginSelect";
            this.LoginSelect.Size = new System.Drawing.Size(56, 17);
            this.LoginSelect.TabIndex = 5;
            this.LoginSelect.TabStop = true;
            this.LoginSelect.Text = "Логин";
            this.LoginSelect.UseVisualStyleBackColor = true;
            this.LoginSelect.CheckedChanged += new System.EventHandler(this.UserSelect_CheckedChanged);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(15, 102);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(255, 20);
            this.LoginTextBox.TabIndex = 6;
            // 
            // FilterLoginForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(285, 187);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginSelect);
            this.Controls.Add(this.UserSelect);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.UserComboBox);
            this.Name = "FilterLoginForm";
            this.Text = "Выбрать пользователя";
            this.Load += new System.EventHandler(this.SelectUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox UserComboBox;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton UserSelect;
        private System.Windows.Forms.RadioButton LoginSelect;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}