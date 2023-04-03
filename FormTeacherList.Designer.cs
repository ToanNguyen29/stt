namespace Day02
{
    partial class FormTeacherList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentDBDataSet4 = new Day02.studentDBDataSet4();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new Day02.studentDBDataSet4TableAdapters.teachersTableAdapter();
            this.studentDBDataSet5 = new Day02.studentDBDataSet5();
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter1 = new Day02.studentDBDataSet5TableAdapters.teachersTableAdapter();
            this.dataGridViewTearcher = new System.Windows.Forms.DataGridView();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTearcher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 126);
            this.panel1.TabIndex = 0;
            // 
            // studentDBDataSet4
            // 
            this.studentDBDataSet4.DataSetName = "studentDBDataSet4";
            this.studentDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.studentDBDataSet4;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // studentDBDataSet5
            // 
            this.studentDBDataSet5.DataSetName = "studentDBDataSet5";
            this.studentDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource1
            // 
            this.teachersBindingSource1.DataMember = "teachers";
            this.teachersBindingSource1.DataSource = this.studentDBDataSet5;
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTearcher
            // 
            this.dataGridViewTearcher.AutoGenerateColumns = false;
            this.dataGridViewTearcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTearcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dataGridViewTearcher.DataSource = this.teachersBindingSource1;
            this.dataGridViewTearcher.Location = new System.Drawing.Point(12, 144);
            this.dataGridViewTearcher.Name = "dataGridViewTearcher";
            this.dataGridViewTearcher.RowHeadersWidth = 51;
            this.dataGridViewTearcher.RowTemplate.Height = 24;
            this.dataGridViewTearcher.Size = new System.Drawing.Size(1070, 150);
            this.dataGridViewTearcher.TabIndex = 1;
            this.dataGridViewTearcher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTearcher_CellContentClick);
            this.dataGridViewTearcher.Click += new System.EventHandler(this.dataGridViewTearcher_Click);
            this.dataGridViewTearcher.DoubleClick += new System.EventHandler(this.dataGridViewTearcher_DoubleClick_1);
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "teacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "teacherID";
            this.teacherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherIDDataGridViewTextBoxColumn.Visible = false;
            this.teacherIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(359, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher List";
            // 
            // FormTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 496);
            this.Controls.Add(this.dataGridViewTearcher);
            this.Controls.Add(this.panel1);
            this.Name = "FormTeacherList";
            this.Text = "FormTeacherList";
            this.Load += new System.EventHandler(this.FormTeacherList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTearcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private studentDBDataSet4 studentDBDataSet4;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private studentDBDataSet4TableAdapters.teachersTableAdapter teachersTableAdapter;
        private studentDBDataSet5 studentDBDataSet5;
        private System.Windows.Forms.BindingSource teachersBindingSource1;
        private studentDBDataSet5TableAdapters.teachersTableAdapter teachersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewTearcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}