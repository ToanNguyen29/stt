using Day02.model;
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
    public partial class FormAdminAddStudentToCourse : Form
    {
        public FormAdminAddStudentToCourse()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            using(var db=new DatabaseContext())
            {
                var st=db.students.Find(textBoxIDStudent.Text);
                if (st != null)
                {
                    labelResult.Text = "Full name: " + st.firstName + " " + st.lastName + " Major: " + st.major + " Gender: " + st.gender + " Birthday: " + st.birthDay.ToString("dd/M/yyyy");
                }
                else
                {
                    MessageBox.Show("Don't exist this student in the list","Add student to course",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            var id_course = FormManageCourses.id_course;
            using(var db=new DatabaseContext())
            {
               var st = db.students.Find(textBoxIDStudent.Text);
                if (st != null)
                {
                    var st_in_c=db.scores.Where(s=>s.courseId==id_course && s.studentId==textBoxIDStudent.Text).Count();
                    if(st_in_c > 0)
                    {
                        MessageBox.Show("This student has been already in this course", "Add student to course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        Score score = new Score
                        {
                            courseId = id_course,
                            studentId = st.mssv,


                        };
                        try
                        {
                            db.scores.Add(score);
                            db.SaveChanges();

                            MessageBox.Show("Add successful", "Add student to course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch
                        {
                            MessageBox.Show("Add unsuccessful", "Add student to course", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Don't exist this student in the list","Add student to course",MessageBoxButtons.OK,MessageBoxIcon.Warning);


                }
            }
        }

        private void buttonCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdminAddStudentToCourse_Load(object sender, EventArgs e)
        {
            labelCourseName.Text = FormManageCourses.name_course;
            
        }
    }
}
