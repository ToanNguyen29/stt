
namespace Day02
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.studentLists = new System.Windows.Forms.ToolStripMenuItem();
            this.statics = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStudents,
            this.courseToolStripMenuItem,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStudents
            // 
            this.menuStudents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudent,
            this.studentLists,
            this.statics,
            this.editRemove,
            this.manageStudentForm,
            this.print});
            this.menuStudents.Name = "menuStudents";
            this.menuStudents.Size = new System.Drawing.Size(74, 24);
            this.menuStudents.Text = "Student";
            // 
            // addNewStudent
            // 
            this.addNewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addNewStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewStudent.Name = "addNewStudent";
            this.addNewStudent.Size = new System.Drawing.Size(239, 26);
            this.addNewStudent.Text = "Add New Student";
            this.addNewStudent.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // studentLists
            // 
            this.studentLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.studentLists.Name = "studentLists";
            this.studentLists.Size = new System.Drawing.Size(239, 26);
            this.studentLists.Text = "Student list";
            this.studentLists.Click += new System.EventHandler(this.studentLists_Click);
            // 
            // statics
            // 
            this.statics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.statics.Name = "statics";
            this.statics.Size = new System.Drawing.Size(239, 26);
            this.statics.Text = "Statics";
            this.statics.Click += new System.EventHandler(this.statics_Click);
            // 
            // editRemove
            // 
            this.editRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.editRemove.Name = "editRemove";
            this.editRemove.Size = new System.Drawing.Size(239, 26);
            this.editRemove.Text = "Edit / Remove";
            // 
            // manageStudentForm
            // 
            this.manageStudentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.manageStudentForm.Name = "manageStudentForm";
            this.manageStudentForm.Size = new System.Drawing.Size(239, 26);
            this.manageStudentForm.Text = "Manage Student Form";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(239, 26);
            this.print.Text = "Print";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.printToolStripMenuItem,
            this.enrollToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageToolStripMenuItem.Text = "Manage Courses";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // enrollToolStripMenuItem
            // 
            this.enrollToolStripMenuItem.Name = "enrollToolStripMenuItem";
            this.enrollToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enrollToolStripMenuItem.Text = "Enroll";
            this.enrollToolStripMenuItem.Click += new System.EventHandler(this.enrollToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStudents;
        private System.Windows.Forms.ToolStripMenuItem addNewStudent;
        private System.Windows.Forms.ToolStripMenuItem studentLists;
        private System.Windows.Forms.ToolStripMenuItem statics;
        private System.Windows.Forms.ToolStripMenuItem editRemove;
        private System.Windows.Forms.ToolStripMenuItem manageStudentForm;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem;
    }
}

