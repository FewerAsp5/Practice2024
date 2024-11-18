namespace FormView
{
    partial class EnterLogForm
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
            this.EnterLogGridView = new System.Windows.Forms.DataGridView();
            this.EnteredAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuccessDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnterLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.Back = new System.Windows.Forms.Button();
            this.EnterLogTableAdapter = new FormView.PracticeDataSetTableAdapters.EnterLogTableAdapter();
            this.Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EnterLogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterLogGridView
            // 
            this.EnterLogGridView.AllowUserToAddRows = false;
            this.EnterLogGridView.AllowUserToDeleteRows = false;
            this.EnterLogGridView.AllowUserToOrderColumns = true;
            this.EnterLogGridView.AutoGenerateColumns = false;
            this.EnterLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnterLogGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnteredAtDataGridViewTextBoxColumn,
            this.UserLoginDataGridViewTextBoxColumn,
            this.UserName,
            this.SuccessDataGridViewCheckBoxColumn});
            this.EnterLogGridView.DataSource = this.EnterLogBindingSource;
            this.EnterLogGridView.Location = new System.Drawing.Point(12, 12);
            this.EnterLogGridView.Name = "EnterLogGridView";
            this.EnterLogGridView.ReadOnly = true;
            this.EnterLogGridView.RowHeadersVisible = false;
            this.EnterLogGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnterLogGridView.Size = new System.Drawing.Size(636, 308);
            this.EnterLogGridView.TabIndex = 0;
            // 
            // EnteredAtDataGridViewTextBoxColumn
            // 
            this.EnteredAtDataGridViewTextBoxColumn.DataPropertyName = "EnteredAt";
            this.EnteredAtDataGridViewTextBoxColumn.HeaderText = "Время входа";
            this.EnteredAtDataGridViewTextBoxColumn.Name = "EnteredAtDataGridViewTextBoxColumn";
            this.EnteredAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.EnteredAtDataGridViewTextBoxColumn.Width = 120;
            // 
            // UserLoginDataGridViewTextBoxColumn
            // 
            this.UserLoginDataGridViewTextBoxColumn.DataPropertyName = "UserLogin";
            this.UserLoginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.UserLoginDataGridViewTextBoxColumn.Name = "UserLoginDataGridViewTextBoxColumn";
            this.UserLoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Имя пользователя";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 280;
            // 
            // SuccessDataGridViewCheckBoxColumn
            // 
            this.SuccessDataGridViewCheckBoxColumn.DataPropertyName = "Success";
            this.SuccessDataGridViewCheckBoxColumn.HeaderText = "Успех";
            this.SuccessDataGridViewCheckBoxColumn.Name = "SuccessDataGridViewCheckBoxColumn";
            this.SuccessDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // EnterLogBindingSource
            // 
            this.EnterLogBindingSource.DataMember = "EnterLog";
            this.EnterLogBindingSource.DataSource = this.PracticeDataSet;
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(549, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // EnterLogTableAdapter
            // 
            this.EnterLogTableAdapter.ClearBeforeFill = true;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(12, 326);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(165, 23);
            this.Filter.TabIndex = 2;
            this.Filter.Text = "Отфильтровать по логину";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // EnterLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EnterLogGridView);
            this.Name = "EnterLogForm";
            this.Text = "История входа";
            this.Load += new System.EventHandler(this.EnterLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnterLogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EnterLogGridView;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource EnterLogBindingSource;
        private PracticeDataSetTableAdapters.EnterLogTableAdapter EnterLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteredAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SuccessDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Filter;
    }
}