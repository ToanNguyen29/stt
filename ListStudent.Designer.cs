
namespace Day02
{
    partial class ListStudent
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
            this.window_studentManagementDataSet = new Day02.window_studentManagementDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Day02.window_studentManagementDataSetTableAdapters.studentsTableAdapter();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.studentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet = new Day02.studentDBDataSet();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.window_studentManagementDataSet3 = new Day02.window_studentManagementDataSet3();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.window_studentManagementDataSet1 = new Day02.window_studentManagementDataSet1();
            this.windowstudentManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter1 = new Day02.window_studentManagementDataSet1TableAdapters.studentsTableAdapter();
            this.studentsTableAdapter2 = new Day02.window_studentManagementDataSet3TableAdapters.studentsTableAdapter();
            this.studentsTableAdapter3 = new Day02.studentDBDataSetTableAdapters.studentsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pirtureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.studentsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet2 = new Day02.studentDBDataSet2();
            this.studentsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.student_mangementDataSet = new Day02.student_mangementDataSet();
            this.studentsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet1 = new Day02.studentDBDataSet1();
            this.studentsTableAdapter4 = new Day02.studentDBDataSet1TableAdapters.studentsTableAdapter();
            this.studentsTableAdapter5 = new Day02.student_mangementDataSetTableAdapters.studentsTableAdapter();
            this.findComboBox = new System.Windows.Forms.ComboBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.studentsTableAdapter6 = new Day02.studentDBDataSet2TableAdapters.studentsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.window_studentManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_studentManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_studentManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowstudentManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_mangementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // window_studentManagementDataSet
            // 
            this.window_studentManagementDataSet.DataSetName = "window_studentManagementDataSet";
            this.window_studentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.window_studentManagementDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(1172, 322);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(210, 83);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // studentsBindingSource3
            // 
            this.studentsBindingSource3.DataMember = "students";
            this.studentsBindingSource3.DataSource = this.studentDBDataSet;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "studentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "students";
            this.studentsBindingSource2.DataSource = this.window_studentManagementDataSet3;
            // 
            // window_studentManagementDataSet3
            // 
            this.window_studentManagementDataSet3.DataSetName = "window_studentManagementDataSet3";
            this.window_studentManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "students";
            this.studentsBindingSource1.DataSource = this.window_studentManagementDataSet1;
            // 
            // window_studentManagementDataSet1
            // 
            this.window_studentManagementDataSet1.DataSetName = "window_studentManagementDataSet1";
            this.window_studentManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // windowstudentManagementDataSetBindingSource
            // 
            this.windowstudentManagementDataSetBindingSource.DataSource = this.window_studentManagementDataSet;
            this.windowstudentManagementDataSetBindingSource.Position = 0;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // studentsTableAdapter2
            // 
            this.studentsTableAdapter2.ClearBeforeFill = true;
            // 
            // studentsTableAdapter3
            // 
            this.studentsTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssvDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.pirtureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(47, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // mssvDataGridViewTextBoxColumn
            // 
            this.mssvDataGridViewTextBoxColumn.DataPropertyName = "mssv";
            this.mssvDataGridViewTextBoxColumn.HeaderText = "mssv";
            this.mssvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mssvDataGridViewTextBoxColumn.Name = "mssvDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // pirtureDataGridViewImageColumn
            // 
            this.pirtureDataGridViewImageColumn.DataPropertyName = "pirture";
            this.pirtureDataGridViewImageColumn.HeaderText = "pirture";
            this.pirtureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.pirtureDataGridViewImageColumn.MinimumWidth = 6;
            this.pirtureDataGridViewImageColumn.Name = "pirtureDataGridViewImageColumn";
            // 
            // studentsBindingSource6
            // 
            this.studentsBindingSource6.DataMember = "students";
            this.studentsBindingSource6.DataSource = this.studentDBDataSet2;
            // 
            // studentDBDataSet2
            // 
            this.studentDBDataSet2.DataSetName = "studentDBDataSet2";
            this.studentDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource5
            // 
            this.studentsBindingSource5.DataMember = "students";
            this.studentsBindingSource5.DataSource = this.student_mangementDataSet;
            // 
            // student_mangementDataSet
            // 
            this.student_mangementDataSet.DataSetName = "student_mangementDataSet";
            this.student_mangementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource4
            // 
            this.studentsBindingSource4.DataMember = "students";
            this.studentsBindingSource4.DataSource = this.studentDBDataSet1;
            // 
            // studentDBDataSet1
            // 
            this.studentDBDataSet1.DataSetName = "studentDBDataSet1";
            this.studentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter4
            // 
            this.studentsTableAdapter4.ClearBeforeFill = true;
            // 
            // studentsTableAdapter5
            // 
            this.studentsTableAdapter5.ClearBeforeFill = true;
            // 
            // findComboBox
            // 
            this.findComboBox.FormattingEnabled = true;
            this.findComboBox.Items.AddRange(new object[] {
            "First name",
            "Last name",
            "Address"});
            this.findComboBox.Location = new System.Drawing.Point(29, 420);
            this.findComboBox.Name = "findComboBox";
            this.findComboBox.Size = new System.Drawing.Size(121, 24);
            this.findComboBox.TabIndex = 3;
            this.findComboBox.SelectedIndexChanged += new System.EventHandler(this.findComboBox_SelectedIndexChanged);
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(158, 422);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(157, 22);
            this.findTextBox.TabIndex = 4;
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBtn.Location = new System.Drawing.Point(346, 380);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(134, 73);
            this.FindBtn.TabIndex = 5;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // studentsTableAdapter6
            // 
            this.studentsTableAdapter6.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNo);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Controls.Add(this.radioButtonFemale);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 76);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(18, 39);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemale.TabIndex = 8;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(111, 39);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMale.TabIndex = 9;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(176, 39);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(46, 20);
            this.radioButtonNo.TabIndex = 10;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // ListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RefreshBtn);
            this.Name = "ListStudent";
            this.Text = "ListStudent";
            this.Load += new System.EventHandler(this.ListStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.window_studentManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_studentManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window_studentManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowstudentManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_mangementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private window_studentManagementDataSet window_studentManagementDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private window_studentManagementDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.BindingSource windowstudentManagementDataSetBindingSource;
        private window_studentManagementDataSet1 window_studentManagementDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private window_studentManagementDataSet1TableAdapters.studentsTableAdapter studentsTableAdapter1;
        private window_studentManagementDataSet3 window_studentManagementDataSet3;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private window_studentManagementDataSet3TableAdapters.studentsTableAdapter studentsTableAdapter2;
        private studentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource3;
        private studentDBDataSetTableAdapters.studentsTableAdapter studentsTableAdapter3;
        private studentDBDataSet1 studentDBDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource4;
        private studentDBDataSet1TableAdapters.studentsTableAdapter studentsTableAdapter4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private student_mangementDataSet student_mangementDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource5;
        private student_mangementDataSetTableAdapters.studentsTableAdapter studentsTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pirtureDataGridViewImageColumn;
        private System.Windows.Forms.ComboBox findComboBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button FindBtn;
        private studentDBDataSet2 studentDBDataSet2;
        private System.Windows.Forms.BindingSource studentsBindingSource6;
        private studentDBDataSet2TableAdapters.studentsTableAdapter studentsTableAdapter6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonNo;
    }
}