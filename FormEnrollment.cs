using Day02.model;
using Microsoft.Office.Interop.Word;
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
    public partial class FormEnrollment : Form
    {
        public FormEnrollment()
        {
            InitializeComponent();
        }

        private void FormEnrollment_Load(object sender, EventArgs e)
        {

            load();

        }
        public  void load()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Register"; // Set the column header text
            buttonColumn.Text = "Enroll"; // Set the button text
            buttonColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons

            // Add the button column to the DataGridView control

            using (var context = new DatabaseContext())
            {
                var teacherCourses = context.courses
                               .Select(c => new {
                                   c.IDcourse,
                                   c.label,
                                   c.period,
                                   c.semester,
                                   c.description,
                                   Teacher = c.Teacher.fname + " " + c.Teacher.sname,
                                   total_student = c.Scores.Count
                               })
                               .ToList();
                dataGridViewEnroll.DataSource = teacherCourses;
                dataGridViewEnroll.Columns.Add(buttonColumn);
            }

        }

        private void dataGridViewEnroll_MouseHover(object sender, EventArgs e)
        {
           

            
        }

        private void dataGridViewEnroll_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id_course = dataGridViewEnroll.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(id_course);
        }

        private void dataGridViewEnroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the button column
            if (e.ColumnIndex == dataGridViewEnroll.Columns[dataGridViewEnroll.ColumnCount-1].Index && e.RowIndex >= 0)
            {
                string id_student = "20110377";
                int max_student_numbers = 40;

                var id_course=dataGridViewEnroll.Rows[e.RowIndex].Cells[0].Value.ToString();

                using (var db = new DatabaseContext())
                {
                    var st = db.students.Find(id_student);
                    if (st != null)
                    {
                        var st_in_c = db.scores.Where(s => s.courseId == id_course && s.studentId == id_student).Count();
                        var total_student=db.scores.Where(s => s.courseId == id_course).Count();
                        if (st_in_c > 0)
                        {
                            MessageBox.Show("This student has been already in this course", "Enroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if(st_in_c==0 && total_student > max_student_numbers)
                        {
                            MessageBox.Show("This coures full students", "Enroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                                MessageBox.Show("Add successful", "Enroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewEnroll.Columns.RemoveAt(dataGridViewEnroll.ColumnCount - 1);
                                load();

                            }
                            catch
                            {
                                MessageBox.Show("Add unsuccessful", "Enroll", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Don't exist this student in the list", "Enroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                    }
                }
            }
            
        }

        private void buttonResultEnroll_Click(object sender, EventArgs e)
        {
            FormResultEnroll formResultEnroll=new FormResultEnroll();
            formResultEnroll.Show();
            formResultEnroll.FormClosed += FormResultEnroll_FormClosed;

        }
        private void FormResultEnroll_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update some data after the form is closed
            dataGridViewEnroll.Columns.RemoveAt(dataGridViewEnroll.ColumnCount - 1);

            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
