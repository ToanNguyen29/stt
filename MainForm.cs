using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

       
        private void addNewStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);

        }

        private void studentLists_Click(object sender, EventArgs e)
        {
            ListStudent listStd = new ListStudent();
            listStd.Show();
        }

        private void statics_Click(object sender, EventArgs e)
        {
            StaticsForm sf= new StaticsForm();
            sf.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCourse addform= new AddNewCourse();
            addform.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse Reform= new RemoveCourse();
            Reform.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourse editCourse= new EditCourse();
            editCourse.Show(this);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageCourses formManageCourses = new FormManageCourses();
            formManageCourses.Show(this);
        }

        private void enrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnrollment formEnrollment= new FormEnrollment();
            formEnrollment.Show(this);
        }
    }
}
