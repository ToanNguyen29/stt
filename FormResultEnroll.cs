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
    public partial class FormResultEnroll : Form
    {
        
        public FormResultEnroll()
        {
            InitializeComponent();
        }

        private void FormResultEnroll_Load(object sender, EventArgs e)
        {

            load();
        }
        public void load()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Register"; // Set the column header text
            buttonColumn.Text = "Cancel"; // Set the button text
            buttonColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons

            // Add the button column to the DataGridView control
            string id_student = "20110377";
            using (var context = new DatabaseContext())
            {
                var courseId = FormManageCourses.id_course;    // replace with your course ID
                var students = context.scores
                                      .Where(s => s.studentId == id_student)
                                      .Join(context.courses,
                                            score => score.courseId,
                                            course => course.IDcourse,
                                            (score, course) => new
                                            {
                                                course.IDcourse,
                                                course.label,
                                                course.semester,
                                                course.period,
                                                tearcher = course.Teacher.fname + course.Teacher.sname

                                            })
                                      .ToList();

                dataGridViewResultEnroll.DataSource = students;
                dataGridViewResultEnroll.Columns.Add(buttonColumn);
            }

        }
        public void load_final()
        {
            /* DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
             buttonColumn.HeaderText = "Register"; // Set the column header text
             buttonColumn.Text = "Cancel"; // Set the button text
             buttonColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons

             // Add the button column to the DataGridView control*/
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Register"; // Set the column header text
            buttonColumn.Text = "Cancel"; // Set the button text
            buttonColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            string id_student = "20110377";
            using (var context = new DatabaseContext())
            {
                var courseId = FormManageCourses.id_course;    // replace with your course ID
                var students = context.scores
                                      .Where(s => s.studentId == id_student)
                                      .Join(context.courses,
                                            score => score.courseId,
                                            course => course.IDcourse,
                                            (score, course) => new
                                            {
                                                course.IDcourse,
                                                course.label,
                                                course.semester,
                                                course.period,
                                                tearcher = course.Teacher.fname + course.Teacher.sname

                                            })
                                      .ToList();

                dataGridViewResultEnroll.DataSource=students;
                dataGridViewResultEnroll.Columns.Remove(buttonColumn);
                dataGridViewResultEnroll.Columns.Add(buttonColumn);
               
            }

        }
        private void dataGridViewResultEnroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridViewResultEnroll.Columns[dataGridViewResultEnroll.ColumnCount - 1].Index && e.RowIndex >= 0)
            {
                string id_student = "20110377";
         
                var id_course = dataGridViewResultEnroll.Rows[e.RowIndex].Cells[0].Value.ToString();

                using (var db = new DatabaseContext())
                {


                    
                    Score enroll = db.scores.Where(s => s.studentId == id_student && s.courseId == id_course).FirstOrDefault();
                    if (enroll != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure cannel this course", "Cancel enroll", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.scores.Remove(enroll);

                            try
                            {
                                db.SaveChanges();
                                
                                MessageBox.Show("Cancelled", "Cancel Enroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewResultEnroll.Columns.RemoveAt(dataGridViewResultEnroll.ColumnCount - 1);
                                load();




                            }
                            catch
                            {
                                MessageBox.Show("Error ", "Cancel Enroll", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {


                        }
                       

                    }
                    else
                    {
                        MessageBox.Show("This course deleted", "Cancel Enroll", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }
            }
        }
    }
}