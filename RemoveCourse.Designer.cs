namespace Day02
{
    partial class RemoveCourse
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
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.iDcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet6 = new Day02.studentDBDataSet6();
            this.coursesTableAdapter = new Day02.studentDBDataSet6TableAdapters.coursesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AllowUserToAddRows = false;
            this.dataGridViewCourse.AllowUserToDeleteRows = false;
            this.dataGridViewCourse.AutoGenerateColumns = false;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcourseDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridViewCourse.DataSource = this.coursesBindingSource;
            this.dataGridViewCourse.Location = new System.Drawing.Point(12, 131);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.ReadOnly = true;
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.RowTemplate.Height = 24;
            this.dataGridViewCourse.Size = new System.Drawing.Size(681, 150);
            this.dataGridViewCourse.TabIndex = 0;
            this.dataGridViewCourse.Click += new System.EventHandler(this.dataGridViewCourse_Click);
            this.dataGridViewCourse.DoubleClick += new System.EventHandler(this.dataGridViewCourse_DoubleClick);
            // 
            // iDcourseDataGridViewTextBoxColumn
            // 
            this.iDcourseDataGridViewTextBoxColumn.DataPropertyName = "IDcourse";
            this.iDcourseDataGridViewTextBoxColumn.HeaderText = "IDcourse";
            this.iDcourseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDcourseDataGridViewTextBoxColumn.Name = "iDcourseDataGridViewTextBoxColumn";
            this.iDcourseDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDcourseDataGridViewTextBoxColumn.Width = 125;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "label";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.ReadOnly = true;
            this.labelDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.studentDBDataSet6;
            // 
            // studentDBDataSet6
            // 
            this.studentDBDataSet6.DataSetName = "studentDBDataSet6";
            this.studentDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course List";
            // 
            // RemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(703, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewCourse);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RemoveCourse";
            this.Text = "RemoveCourse";
            this.Load += new System.EventHandler(this.RemoveCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private studentDBDataSet6 studentDBDataSet6;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private studentDBDataSet6TableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}