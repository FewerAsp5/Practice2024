namespace FormView
{
    partial class FindRequestForm
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
            this.RequestID = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            this.FilterByUser = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.CompletedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestID
            // 
            this.RequestID.Location = new System.Drawing.Point(213, 2);
            this.RequestID.Name = "RequestID";
            this.RequestID.Size = new System.Drawing.Size(121, 20);
            this.RequestID.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 163);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер заявки";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(213, 28);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(121, 20);
            this.Description.TabIndex = 5;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(213, 54);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(121, 20);
            this.Status.TabIndex = 6;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(213, 80);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(121, 20);
            this.StartDate.TabIndex = 7;
            // 
            // UserComboBox
            // 
            this.UserComboBox.DataSource = this.UsersBindingSource;
            this.UserComboBox.DisplayMember = "fio";
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.Enabled = false;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(213, 106);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserComboBox.TabIndex = 8;
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
            // FilterByUser
            // 
            this.FilterByUser.AutoSize = true;
            this.FilterByUser.Location = new System.Drawing.Point(12, 108);
            this.FilterByUser.Name = "FilterByUser";
            this.FilterByUser.Size = new System.Drawing.Size(65, 17);
            this.FilterByUser.TabIndex = 9;
            this.FilterByUser.Text = "Клиент:";
            this.FilterByUser.UseVisualStyleBackColor = true;
            this.FilterByUser.CheckedChanged += new System.EventHandler(this.FilterByUser_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание неполадки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Состояние заявки";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(12, 83);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(71, 13);
            this.StartDateLabel.TabIndex = 12;
            this.StartDateLabel.Text = "Дата начала";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(259, 163);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // CompletedOnlyCheckBox
            // 
            this.CompletedOnlyCheckBox.AutoSize = true;
            this.CompletedOnlyCheckBox.Location = new System.Drawing.Point(12, 131);
            this.CompletedOnlyCheckBox.Name = "CompletedOnlyCheckBox";
            this.CompletedOnlyCheckBox.Size = new System.Drawing.Size(239, 17);
            this.CompletedOnlyCheckBox.TabIndex = 14;
            this.CompletedOnlyCheckBox.Text = "Показывать только завершенные заявки";
            this.CompletedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindRequestForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(346, 195);
            this.Controls.Add(this.CompletedOnlyCheckBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterByUser);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.RequestID);
            this.Name = "FindRequestForm";
            this.Text = "Найти заявку";
            this.Load += new System.EventHandler(this.FindRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RequestID;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.ComboBox UserComboBox;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
        private System.Windows.Forms.CheckBox FilterByUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox CompletedOnlyCheckBox;
    }
}