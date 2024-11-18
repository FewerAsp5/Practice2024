namespace FormView
{
    partial class OngoingTechForm
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
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.OrgTechModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrgTechModelTableAdapter = new FormView.PracticeDataSetTableAdapters.orgTechModelTableAdapter();
            this.OngoingTech = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.RequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTechModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngoingTech)).BeginInit();
            this.SuspendLayout();
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrgTechModelBindingSource
            // 
            this.OrgTechModelBindingSource.DataMember = "orgTechModel";
            this.OrgTechModelBindingSource.DataSource = this.PracticeDataSet;
            // 
            // OrgTechModelTableAdapter
            // 
            this.OrgTechModelTableAdapter.ClearBeforeFill = true;
            // 
            // OngoingTech
            // 
            this.OngoingTech.AllowUserToAddRows = false;
            this.OngoingTech.AllowUserToDeleteRows = false;
            this.OngoingTech.AutoGenerateColumns = false;
            this.OngoingTech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OngoingTech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestId,
            this.Model,
            this.TechType,
            this.ClientColumn,
            this.MasterColumn});
            this.OngoingTech.DataSource = this.OrgTechModelBindingSource;
            this.OngoingTech.Location = new System.Drawing.Point(12, 33);
            this.OngoingTech.MultiSelect = false;
            this.OngoingTech.Name = "OngoingTech";
            this.OngoingTech.ReadOnly = true;
            this.OngoingTech.RowHeadersVisible = false;
            this.OngoingTech.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OngoingTech.Size = new System.Drawing.Size(865, 325);
            this.OngoingTech.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(713, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Назад";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // RequestId
            // 
            this.RequestId.DataPropertyName = "Id";
            this.RequestId.HeaderText = "Номер заказа";
            this.RequestId.Name = "RequestId";
            this.RequestId.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Модель оборудования";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 130;
            // 
            // TechType
            // 
            this.TechType.DataPropertyName = "typeName";
            this.TechType.HeaderText = "Тип обрудования";
            this.TechType.Name = "TechType";
            this.TechType.ReadOnly = true;
            // 
            // ClientColumn
            // 
            this.ClientColumn.DataPropertyName = "ClientFio";
            this.ClientColumn.HeaderText = "Клиент";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            this.ClientColumn.Width = 250;
            // 
            // MasterColumn
            // 
            this.MasterColumn.DataPropertyName = "MasterFio";
            this.MasterColumn.HeaderText = "Мастер";
            this.MasterColumn.Name = "MasterColumn";
            this.MasterColumn.ReadOnly = true;
            this.MasterColumn.Width = 250;
            // 
            // OngoingTechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OngoingTech);
            this.Name = "OngoingTechForm";
            this.Text = "Техника в ремонте";
            this.Load += new System.EventHandler(this.OngoingTechForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTechModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OngoingTech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource OrgTechModelBindingSource;
        private PracticeDataSetTableAdapters.orgTechModelTableAdapter OrgTechModelTableAdapter;
        private System.Windows.Forms.DataGridView OngoingTech;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasterColumn;
    }
}