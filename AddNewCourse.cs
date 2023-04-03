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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day02
{
    public partial class AddNewCourse : Form
    {
        public AddNewCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DatabaseContext db= new DatabaseContext();

            if(textBoxLabel.Text.Trim() == "") {
                MessageBox.Show("Add A Course Name","Add Course",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(db.courses.Where(c=>c.label==textBoxLabel.Text).Count() == 0)
            {
                if (comboBoxSemester.Text != "")
                {
                       
                        if (FormTeacherList.idteacher != -1)
                        {

                            course c = new course
                            {
                                semester = comboBoxSemester.Text,
                                IDcourse = textBoxCourseID.Text,
                                label = textBoxLabel.Text,
                                period = int.Parse(textBoxPeriod.Text),
                                description = richTextBoxDescription.Text,
                                TeacherId= FormTeacherList.idteacher
                            };
                            db.courses.Add(c);
                            try
                            {
                                db.SaveChanges();
                                MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Course Not nserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        };

                    }
                        else
                        {
                            course c = new course
                            {
                                semester = comboBoxSemester.Text,
                                IDcourse = textBoxCourseID.Text,
                                label = textBoxLabel.Text,
                                period = int.Parse(textBoxPeriod.Text),
                                description = richTextBoxDescription.Text,

                            };
                            db.courses.Add(c);
                            try
                            {
                                db.SaveChanges();
                                MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Course Not nserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            };
                    }
                       
                    
                    


                }
                
                else
                {
                    MessageBox.Show("Need choose semester", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
            else
            {
                MessageBox.Show("This Course Name Already", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxCourseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void AddNewCourse_Load(object sender, EventArgs e)
        {
        }

        private void buttonSelectTeacher_Click(object sender, EventArgs e)
        {
            FormTeacherList formTeacherList=new FormTeacherList();
            formTeacherList.Show(this);
            textBoxTearchLastName.Text = FormTeacherList.tearchFullname;
            
        }
    }
}
