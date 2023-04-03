using Day02.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using Day02.tool;

namespace Day02
{
    public partial class FormManageCourses : Form
    {
        public static string id_course = "";
        public static string name_course = "";
        public FormManageCourses()
        {
            InitializeComponent();
        }

        private void FormManageCourses_Load(object sender, EventArgs e)
        {

            using (var context = new DatabaseContext())
            {
                var teacherCourses = context.courses
                               .Select(c => new
                               {
                                   c.IDcourse,
                                   c.label,
                                   c.period,
                                   c.semester,
                                   c.description,
                                   Teacher = c.Teacher.fname + " " + c.Teacher.sname,
                                   total_student = c.Scores.Count
                               })
                               .ToList();
                dataGridView1.DataSource = teacherCourses;
            }



        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_course = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name_course = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            FormStudentsInCourse formStudentsInCourse = new FormStudentsInCourse();
            formStudentsInCourse.Show();
        }

        private void buttonAddStudentToCourse_Click(object sender, EventArgs e)
        {
            FormAdminAddStudentToCourse formAdminAddStudentToCourse = new FormAdminAddStudentToCourse();
            formAdminAddStudentToCourse.Show();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var d = DocumentFactoryHelpers.CreateDocument("Word");
            d.Print(dataGridView1);
            
            




           /* PrintDataGridViewToPdf(dataGridView1,"default");*/



        }

        private void buttonPrintExcel_Click(object sender, EventArgs e)
        {
            var d = DocumentFactoryHelpers.CreateDocument("Excel");
            d.Print(dataGridView1);
        }

        private void buttonPrintPDF_Click(object sender, EventArgs e)
        {
            var d = DocumentFactoryHelpers.CreateDocument("PDF");
            d.Print(dataGridView1);
        }
    }
}