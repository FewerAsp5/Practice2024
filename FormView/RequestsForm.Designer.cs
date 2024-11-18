namespace FormView
{
    partial class RequestsForm
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
            this.RequestGrid = new System.Windows.Forms.DataGridView();
            this.RequestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemDescryptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplectionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutionTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.ChangeDescription = new System.Windows.Forms.Button();
            this.RequestsTableAdapter = new FormView.PracticeDataSetTableAdapters.RequestsTableAdapter();
            this.FindRequest = new System.Windows.Forms.Button();
            this.SetMaster = new System.Windows.Forms.Button();
            this.Parts = new System.Windows.Forms.Button();
            this.RequestCountlabel = new System.Windows.Forms.Label();
            this.RequestCount = new System.Windows.Forms.TextBox();
            this.AverageTimeLabel = new System.Windows.Forms.Label();
            this.AverageTime = new System.Windows.Forms.TextBox();
            this.ChangeStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
            this.CommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommentsTableAdapter = new FormView.PracticeDataSetTableAdapters.CommentsTableAdapter();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.TypeTableAdapter = new FormView.PracticeDataSetTableAdapters.TYPETableAdapter();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalRequest = new System.Windows.Forms.TextBox();
            this.DeleteRequest = new System.Windows.Forms.Button();
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RequestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestGrid
            // 
            this.RequestGrid.AllowUserToAddRows = false;
            this.RequestGrid.AllowUserToDeleteRows = false;
            this.RequestGrid.AutoGenerateColumns = false;
            this.RequestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestIdColumn,
            this.StartDateDataGridViewTextBoxColumn,
            this.ProblemDescryptionDataGridViewTextBoxColumn,
            this.RequestStatusDataGridViewTextBoxColumn,
            this.ComplectionDateDataGridViewTextBoxColumn,
            this.RepairPartsDataGridViewTextBoxColumn,
            this.Model,
            this.MasterColumn,
            this.ClientColumn,
            this.ExecutionTimeColumn});
            this.RequestGrid.DataSource = this.RequestsBindingSource;
            this.RequestGrid.Location = new System.Drawing.Point(12, 52);
            this.RequestGrid.MultiSelect = false;
            this.RequestGrid.Name = "RequestGrid";
            this.RequestGrid.ReadOnly = true;
            this.RequestGrid.RowHeadersVisible = false;
            this.RequestGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequestGrid.Size = new System.Drawing.Size(915, 241);
            this.RequestGrid.TabIndex = 0;
            this.RequestGrid.SelectionChanged += new System.EventHandler(this.RequestGrid_SelectionChanged);
            // 
            // RequestIdColumn
            // 
            this.RequestIdColumn.DataPropertyName = "requestID";
            this.RequestIdColumn.HeaderText = "Номер";
            this.RequestIdColumn.Name = "RequestIdColumn";
            this.RequestIdColumn.ReadOnly = true;
            // 
            // StartDateDataGridViewTextBoxColumn
            // 
            this.StartDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.StartDateDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn";
            this.StartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProblemDescryptionDataGridViewTextBoxColumn
            // 
            this.ProblemDescryptionDataGridViewTextBoxColumn.DataPropertyName = "problemDescryption";
            this.ProblemDescryptionDataGridViewTextBoxColumn.HeaderText = "Описание неполадки";
            this.ProblemDescryptionDataGridViewTextBoxColumn.Name = "ProblemDescryptionDataGridViewTextBoxColumn";
            this.ProblemDescryptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RequestStatusDataGridViewTextBoxColumn
            // 
            this.RequestStatusDataGridViewTextBoxColumn.DataPropertyName = "requestStatus";
            this.RequestStatusDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.RequestStatusDataGridViewTextBoxColumn.Name = "RequestStatusDataGridViewTextBoxColumn";
            this.RequestStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.RequestStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ComplectionDateDataGridViewTextBoxColumn
            // 
            this.ComplectionDateDataGridViewTextBoxColumn.DataPropertyName = "complectionDate";
            this.ComplectionDateDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            this.ComplectionDateDataGridViewTextBoxColumn.Name = "ComplectionDateDataGridViewTextBoxColumn";
            this.ComplectionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RepairPartsDataGridViewTextBoxColumn
            // 
            this.RepairPartsDataGridViewTextBoxColumn.DataPropertyName = "repairParts";
            this.RepairPartsDataGridViewTextBoxColumn.HeaderText = "Запчасти";
            this.RepairPartsDataGridViewTextBoxColumn.Name = "RepairPartsDataGridViewTextBoxColumn";
            this.RepairPartsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Устройство в ремонте";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // MasterColumn
            // 
            this.MasterColumn.DataPropertyName = "MasterFio";
            this.MasterColumn.HeaderText = "Мастер";
            this.MasterColumn.Name = "MasterColumn";
            this.MasterColumn.ReadOnly = true;
            // 
            // ClientColumn
            // 
            this.ClientColumn.DataPropertyName = "ClientFio";
            this.ClientColumn.HeaderText = "Клиент";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            // 
            // ExecutionTimeColumn
            // 
            this.ExecutionTimeColumn.DataPropertyName = "Duration";
            this.ExecutionTimeColumn.HeaderText = "Время обработки";
            this.ExecutionTimeColumn.Name = "ExecutionTimeColumn";
            this.ExecutionTimeColumn.ReadOnly = true;
            this.ExecutionTimeColumn.Visible = false;
            // 
            // RequestsBindingSource
            // 
            this.RequestsBindingSource.DataMember = "Requests";
            this.RequestsBindingSource.DataSource = this.PracticeDataSet;
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChangeDescription
            // 
            this.ChangeDescription.Location = new System.Drawing.Point(12, 415);
            this.ChangeDescription.Name = "ChangeDescription";
            this.ChangeDescription.Size = new System.Drawing.Size(120, 23);
            this.ChangeDescription.TabIndex = 1;
            this.ChangeDescription.Text = "Изменить описание";
            this.ChangeDescription.UseVisualStyleBackColor = true;
            this.ChangeDescription.Click += new System.EventHandler(this.ChangeDescription_Click);
            // 
            // RequestsTableAdapter
            // 
            this.RequestsTableAdapter.ClearBeforeFill = true;
            // 
            // FindRequest
            // 
            this.FindRequest.Location = new System.Drawing.Point(138, 415);
            this.FindRequest.Name = "FindRequest";
            this.FindRequest.Size = new System.Drawing.Size(120, 23);
            this.FindRequest.TabIndex = 2;
            this.FindRequest.Text = "Найти заявку";
            this.FindRequest.UseVisualStyleBackColor = true;
            this.FindRequest.Click += new System.EventHandler(this.FindRequest_Click);
            // 
            // SetMaster
            // 
            this.SetMaster.Location = new System.Drawing.Point(264, 415);
            this.SetMaster.Name = "SetMaster";
            this.SetMaster.Size = new System.Drawing.Size(120, 23);
            this.SetMaster.TabIndex = 3;
            this.SetMaster.Text = "Назначить мастера";
            this.SetMaster.UseVisualStyleBackColor = true;
            this.SetMaster.Click += new System.EventHandler(this.SetMaster_Click);
            // 
            // Parts
            // 
            this.Parts.Location = new System.Drawing.Point(390, 415);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(120, 23);
            this.Parts.TabIndex = 4;
            this.Parts.Text = "Запчасти";
            this.Parts.UseVisualStyleBackColor = true;
            this.Parts.Click += new System.EventHandler(this.Parts_Click);
            // 
            // RequestCountlabel
            // 
            this.RequestCountlabel.AutoSize = true;
            this.RequestCountlabel.Location = new System.Drawing.Point(586, 9);
            this.RequestCountlabel.Name = "RequestCountlabel";
            this.RequestCountlabel.Size = new System.Drawing.Size(108, 13);
            this.RequestCountlabel.TabIndex = 5;
            this.RequestCountlabel.Text = "Количество заявок:";
            // 
            // RequestCount
            // 
            this.RequestCount.Location = new System.Drawing.Point(712, 6);
            this.RequestCount.Name = "RequestCount";
            this.RequestCount.ReadOnly = true;
            this.RequestCount.Size = new System.Drawing.Size(44, 20);
            this.RequestCount.TabIndex = 6;
            // 
            // AverageTimeLabel
            // 
            this.AverageTimeLabel.AutoSize = true;
            this.AverageTimeLabel.Location = new System.Drawing.Point(196, 302);
            this.AverageTimeLabel.Name = "AverageTimeLabel";
            this.AverageTimeLabel.Size = new System.Drawing.Size(190, 13);
            this.AverageTimeLabel.TabIndex = 7;
            this.AverageTimeLabel.Text = "Среднее время исполнения заявки:";
            // 
            // AverageTime
            // 
            this.AverageTime.Location = new System.Drawing.Point(392, 302);
            this.AverageTime.Name = "AverageTime";
            this.AverageTime.ReadOnly = true;
            this.AverageTime.Size = new System.Drawing.Size(147, 20);
            this.AverageTime.TabIndex = 8;
            // 
            // ChangeStatus
            // 
            this.ChangeStatus.Location = new System.Drawing.Point(516, 415);
            this.ChangeStatus.Name = "ChangeStatus";
            this.ChangeStatus.Size = new System.Drawing.Size(120, 23);
            this.ChangeStatus.TabIndex = 9;
            this.ChangeStatus.Text = "Изменить статус";
            this.ChangeStatus.UseVisualStyleBackColor = true;
            this.ChangeStatus.Click += new System.EventHandler(this.ChangeStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Комментарий:";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(105, 328);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(434, 20);
            this.Comment.TabIndex = 11;
            this.Comment.Leave += new System.EventHandler(this.Comment_Leave);
            // 
            // CommentsBindingSource
            // 
            this.CommentsBindingSource.DataMember = "Comments";
            this.CommentsBindingSource.DataSource = this.PracticeDataSet;
            // 
            // CommentsTableAdapter
            // 
            this.CommentsTableAdapter.ClearBeforeFill = true;
            // 
            // RoleLabel
            // 
            this.RoleLabel.Location = new System.Drawing.Point(12, 9);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(100, 23);
            this.RoleLabel.TabIndex = 12;
            this.RoleLabel.Text = "label2";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(118, 6);
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(421, 20);
            this.UserName.TabIndex = 13;
            // 
            // TypeTableAdapter
            // 
            this.TypeTableAdapter.ClearBeforeFill = true;
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(852, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 14;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "из";
            // 
            // TotalRequest
            // 
            this.TotalRequest.Location = new System.Drawing.Point(783, 6);
            this.TotalRequest.Name = "TotalRequest";
            this.TotalRequest.ReadOnly = true;
            this.TotalRequest.Size = new System.Drawing.Size(44, 20);
            this.TotalRequest.TabIndex = 16;
            // 
            // DeleteRequest
            // 
            this.DeleteRequest.Location = new System.Drawing.Point(642, 415);
            this.DeleteRequest.Name = "DeleteRequest";
            this.DeleteRequest.Size = new System.Drawing.Size(120, 23);
            this.DeleteRequest.TabIndex = 17;
            this.DeleteRequest.Text = "Удалить заявку";
            this.DeleteRequest.UseVisualStyleBackColor = true;
            this.DeleteRequest.Click += new System.EventHandler(this.DeleteRequest_Click);
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.DeleteRequest);
            this.Controls.Add(this.TotalRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeStatus);
            this.Controls.Add(this.AverageTime);
            this.Controls.Add(this.AverageTimeLabel);
            this.Controls.Add(this.RequestCount);
            this.Controls.Add(this.RequestCountlabel);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.SetMaster);
            this.Controls.Add(this.FindRequest);
            this.Controls.Add(this.ChangeDescription);
            this.Controls.Add(this.RequestGrid);
            this.Name = "RequestsForm";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RequestGrid;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource RequestsBindingSource;
        private PracticeDataSetTableAdapters.RequestsTableAdapter RequestsTableAdapter;
        private System.Windows.Forms.Button ChangeDescription;
        private System.Windows.Forms.Button FindRequest;
        private System.Windows.Forms.Button SetMaster;
        private System.Windows.Forms.Button Parts;
        private System.Windows.Forms.Label RequestCountlabel;
        private System.Windows.Forms.TextBox RequestCount;
        private System.Windows.Forms.Label AverageTimeLabel;
        private System.Windows.Forms.TextBox AverageTime;
        private System.Windows.Forms.Button ChangeStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.BindingSource CommentsBindingSource;
        private PracticeDataSetTableAdapters.CommentsTableAdapter CommentsTableAdapter;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox UserName;
        private PracticeDataSetTableAdapters.TYPETableAdapter TypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemDescryptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplectionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutionTimeColumn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalRequest;
        private System.Windows.Forms.Button DeleteRequest;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
    }
}