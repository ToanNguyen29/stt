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
    public partial class RemoveCourse : Form
    {   public static string id_course="";
        public RemoveCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet6.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentDBDataSet6.courses);

        }

        private void dataGridViewCourse_DoubleClick(object sender, EventArgs e)
        {
            id_course = dataGridViewCourse.CurrentRow.Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure remove this course", "Remove Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using(DatabaseContext db=new DatabaseContext())
                {
                    var cour = db.courses.Find(id_course);
                    db.courses.Remove(cour);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.coursesTableAdapter.Fill(this.studentDBDataSet6.courses);

                    }
                    catch
                    {
                        MessageBox.Show("Remove Error", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      

                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
               

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewCourse_Click(object sender, EventArgs e)
        {

            id_course = dataGridViewCourse.CurrentRow.Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure remove this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    var cour = db.courses.Find(id_course);
                    db.courses.Remove(cour);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.coursesTableAdapter.Fill(this.studentDBDataSet6.courses);

                    }
                    catch
                    {
                        MessageBox.Show("Remove Error", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {


            }
        }
    }
}
