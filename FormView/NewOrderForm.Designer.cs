namespace FormView
{
    partial class NewOrderForm
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProblemDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelType = new System.Windows.Forms.ComboBox();
            this.TechTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeDataSet = new FormView.PracticeDataSet();
            this.TechTypeTableAdapter = new FormView.PracticeDataSetTableAdapters.TechTypeTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientList = new System.Windows.Forms.ComboBox();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersTableAdapter = new FormView.PracticeDataSetTableAdapters.USERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TechTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 155);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(713, 155);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание проблемы:";
            // 
            // ProblemDescr
            // 
            this.ProblemDescr.Location = new System.Drawing.Point(130, 6);
            this.ProblemDescr.Name = "ProblemDescr";
            this.ProblemDescr.Size = new System.Drawing.Size(658, 20);
            this.ProblemDescr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип оборудования";
            // 
            // ModelType
            // 
            this.ModelType.DataSource = this.TechTypeBindingSource;
            this.ModelType.DisplayMember = "typeName";
            this.ModelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelType.FormattingEnabled = true;
            this.ModelType.Location = new System.Drawing.Point(130, 32);
            this.ModelType.Name = "ModelType";
            this.ModelType.Size = new System.Drawing.Size(139, 21);
            this.ModelType.TabIndex = 5;
            this.ModelType.ValueMember = "TechTypeID";
            // 
            // TechTypeBindingSource
            // 
            this.TechTypeBindingSource.DataMember = "TechType";
            this.TechTypeBindingSource.DataSource = this.PracticeDataSet;
            // 
            // PracticeDataSet
            // 
            this.PracticeDataSet.DataSetName = "PracticeDataSet";
            this.PracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TechTypeTableAdapter
            // 
            this.TechTypeTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование модели:";
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(408, 33);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(380, 20);
            this.ModelName.TabIndex = 7;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(582, 67);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(46, 13);
            this.ClientLabel.TabIndex = 8;
            this.ClientLabel.Text = "Клиент:";
            // 
            // ClientList
            // 
            this.ClientList.DataSource = this.UsersBindingSource;
            this.ClientList.DisplayMember = "fio";
            this.ClientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientList.FormattingEnabled = true;
            this.ClientList.Location = new System.Drawing.Point(634, 64);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(154, 21);
            this.ClientList.TabIndex = 9;
            this.ClientList.ValueMember = "userID";
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
            // NewOrderForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(800, 190);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.ModelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProblemDescr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "NewOrderForm";
            this.Text = "Новая заявка";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TechTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProblemDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModelType;
        private PracticeDataSet PracticeDataSet;
        private System.Windows.Forms.BindingSource TechTypeBindingSource;
        private PracticeDataSetTableAdapters.TechTypeTableAdapter TechTypeTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.ComboBox ClientList;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private PracticeDataSetTableAdapters.USERSTableAdapter UsersTableAdapter;
    }
}