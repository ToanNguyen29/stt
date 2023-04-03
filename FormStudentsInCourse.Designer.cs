namespace Day02
{
    partial class FormStudentsInCourse
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
            this.dataGridViewStudentInCourse = new System.Windows.Forms.DataGridView();
            this.labelCourse_Name = new System.Windows.Forms.Label();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.buttonAddStudentToCourse = new System.Windows.Forms.Button();
            this.buttonPrintExcel = new System.Windows.Forms.Button();
            this.buttonPrintPDF = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentInCourse
            // 
            this.dataGridViewStudentInCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentInCourse.Location = new System.Drawing.Point(29, 115);
            this.dataGridViewStudentInCourse.Name = "dataGridViewStudentInCourse";
            this.dataGridViewStudentInCourse.RowHeadersWidth = 51;
            this.dataGridViewStudentInCourse.RowTemplate.Height = 24;
            this.dataGridViewStudentInCourse.Size = new System.Drawing.Size(1107, 150);
            this.dataGridViewStudentInCourse.TabIndex = 0;
            // 
            // labelCourse_Name
            // 
            this.labelCourse_Name.AutoSize = true;
            this.labelCourse_Name.Location = new System.Drawing.Point(26, 46);
            this.labelCourse_Name.Name = "labelCourse_Name";
            this.labelCourse_Name.Size = new System.Drawing.Size(44, 16);
            this.labelCourse_Name.TabIndex = 1;
            this.labelCourse_Name.Text = "label1";
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.AutoSize = true;
            this.labelTotalStudent.Location = new System.Drawing.Point(619, 45);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(44, 16);
            this.labelTotalStudent.TabIndex = 2;
            this.labelTotalStudent.Text = "label1";
            // 
            // buttonAddStudentToCourse
            // 
            this.buttonAddStudentToCourse.Location = new System.Drawing.Point(953, 346);
            this.buttonAddStudentToCourse.Name = "buttonAddStudentToCourse";
            this.buttonAddStudentToCourse.Size = new System.Drawing.Size(183, 52);
            this.buttonAddStudentToCourse.TabIndex = 3;
            this.buttonAddStudentToCourse.Text = "Add Student to Course";
            this.buttonAddStudentToCourse.UseVisualStyleBackColor = true;
            this.buttonAddStudentToCourse.Click += new System.EventHandler(this.buttonAddStudentToCourse_Click);
            // 
            // buttonPrintExcel
            // 
            this.buttonPrintExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPrintExcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintExcel.Location = new System.Drawing.Point(494, 346);
            this.buttonPrintExcel.Name = "buttonPrintExcel";
            this.buttonPrintExcel.Size = new System.Drawing.Size(203, 55);
            this.buttonPrintExcel.TabIndex = 13;
            this.buttonPrintExcel.Text = "Print Excel";
            this.buttonPrintExcel.UseVisualStyleBackColor = false;
            this.buttonPrintExcel.Click += new System.EventHandler(this.buttonPrintExcel_Click);
            // 
            // buttonPrintPDF
            // 
            this.buttonPrintPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPrintPDF.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintPDF.Location = new System.Drawing.Point(258, 346);
            this.buttonPrintPDF.Name = "buttonPrintPDF";
            this.buttonPrintPDF.Size = new System.Drawing.Size(203, 55);
            this.buttonPrintPDF.TabIndex = 12;
            this.buttonPrintPDF.Text = "Print PDF";
            this.buttonPrintPDF.UseVisualStyleBackColor = false;
            this.buttonPrintPDF.Click += new System.EventHandler(this.buttonPrintPDF_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(12, 346);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(204, 55);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(728, 346);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(203, 55);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Print Word";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FormStudentsInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.buttonPrintExcel);
            this.Controls.Add(this.buttonPrintPDF);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonAddStudentToCourse);
            this.Controls.Add(this.labelTotalStudent);
            this.Controls.Add(this.labelCourse_Name);
            this.Controls.Add(this.dataGridViewStudentInCourse);
            this.Name = "FormStudentsInCourse";
            this.Text = "FormStudentsInCourse";
            this.Load += new System.EventHandler(this.FormStudentsInCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentInCourse;
        private System.Windows.Forms.Label labelCourse_Name;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Button buttonAddStudentToCourse;
        private System.Windows.Forms.Button buttonPrintExcel;
        private System.Windows.Forms.Button buttonPrintPDF;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPrint;
    }
}