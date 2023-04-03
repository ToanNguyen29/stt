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
    public partial class FormStudentsInCourse : Form
    {
        public FormStudentsInCourse()
        {
            InitializeComponent();
        }

        private void FormStudentsInCourse_Load(object sender, EventArgs e)
        {
            labelCourse_Name.Text = FormManageCourses.name_course;
            using (var context = new DatabaseContext())
            {
                var courseId = FormManageCourses.id_course;    // replace with your course ID
                var students = context.scores
                                      .Where(s => s.courseId == courseId)
                                      .Join(context.students,
                                            score => score.studentId,
                                            student => student.mssv,
                                            (score, student) => new {
                                                student.mssv,
                                                student.firstName,
                                                student.lastName,
                                                student.gender,
                                                student.email,
                                                student.phone,
                                                student.birthDay,
                                                student.major
                                            })
                                      .ToList();
                
                dataGridViewStudentInCourse.DataSource = students;
                labelTotalStudent.Text=dataGridViewStudentInCourse.RowCount.ToString();
            }

        }

        private void buttonAddStudentToCourse_Click(object sender, EventArgs e)
        {
            FormAdminAddStudentToCourse formAdminAddStudentToCourse=new FormAdminAddStudentToCourse();
            formAdminAddStudentToCourse.Show();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var doc = DocumentFactoryHelpers.CreateDocument("Word");
            doc.Print(dataGridViewStudentInCourse);
        }

        private void buttonPrintExcel_Click(object sender, EventArgs e)
        {
            var doc = DocumentFactoryHelpers.CreateDocument("Excel");
            doc.Print(dataGridViewStudentInCourse);
        }

        private void buttonPrintPDF_Click(object sender, EventArgs e)
        {
            var doc = DocumentFactoryHelpers.CreateDocument("PDF");
            doc.Print(dataGridViewStudentInCourse);
        }
    }
}
