namespace Day02
{
    partial class FormManageCourses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentDBDataSet7 = new Day02.studentDBDataSet7();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Day02.studentDBDataSet7TableAdapters.coursesTableAdapter();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPrintPDF = new System.Windows.Forms.Button();
            this.buttonPrintExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(882, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // studentDBDataSet7
            // 
            this.studentDBDataSet7.DataSetName = "studentDBDataSet7";
            this.studentDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.studentDBDataSet7;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(691, 459);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(203, 55);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Print Word";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(29, 459);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(204, 55);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonPrintPDF
            // 
            this.buttonPrintPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPrintPDF.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintPDF.Location = new System.Drawing.Point(261, 459);
            this.buttonPrintPDF.Name = "buttonPrintPDF";
            this.buttonPrintPDF.Size = new System.Drawing.Size(203, 55);
            this.buttonPrintPDF.TabIndex = 8;
            this.buttonPrintPDF.Text = "Print PDF";
            this.buttonPrintPDF.UseVisualStyleBackColor = false;
            this.buttonPrintPDF.Click += new System.EventHandler(this.buttonPrintPDF_Click);
            // 
            // buttonPrintExcel
            // 
            this.buttonPrintExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPrintExcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintExcel.Location = new System.Drawing.Point(482, 459);
            this.buttonPrintExcel.Name = "buttonPrintExcel";
            this.buttonPrintExcel.Size = new System.Drawing.Size(203, 55);
            this.buttonPrintExcel.TabIndex = 9;
            this.buttonPrintExcel.Text = "Print Excel";
            this.buttonPrintExcel.UseVisualStyleBackColor = false;
            this.buttonPrintExcel.Click += new System.EventHandler(this.buttonPrintExcel_Click);
            // 
            // FormManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 547);
            this.Controls.Add(this.buttonPrintExcel);
            this.Controls.Add(this.buttonPrintPDF);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormManageCourses";
            this.Text = "FormManageCourses";
            this.Load += new System.EventHandler(this.FormManageCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentDBDataSet7 studentDBDataSet7;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private studentDBDataSet7TableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPrintPDF;
        private System.Windows.Forms.Button buttonPrintExcel;
    }
}