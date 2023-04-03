namespace Day02
{
    partial class FormAdminAddStudentToCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDStudent = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.buttonCannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // textBoxIDStudent
            // 
            this.textBoxIDStudent.Location = new System.Drawing.Point(161, 86);
            this.textBoxIDStudent.Name = "textBoxIDStudent";
            this.textBoxIDStudent.Size = new System.Drawing.Size(139, 22);
            this.textBoxIDStudent.TabIndex = 1;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(357, 81);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(86, 33);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(62, 164);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 54);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(59, 46);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(44, 16);
            this.labelCourseName.TabIndex = 5;
            this.labelCourseName.Text = "label2";
            // 
            // buttonCannel
            // 
            this.buttonCannel.Location = new System.Drawing.Point(138, 337);
            this.buttonCannel.Name = "buttonCannel";
            this.buttonCannel.Size = new System.Drawing.Size(176, 54);
            this.buttonCannel.TabIndex = 6;
            this.buttonCannel.Text = "Cancel";
            this.buttonCannel.UseVisualStyleBackColor = true;
            this.buttonCannel.Click += new System.EventHandler(this.buttonCannel_Click);
            // 
            // FormAdminAddStudentToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCannel);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxIDStudent);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminAddStudentToCourse";
            this.Text = "FormAdminAddStudentToCourse";
            this.Load += new System.EventHandler(this.FormAdminAddStudentToCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDStudent;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Button buttonCannel;
    }
}