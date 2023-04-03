using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class EditCourse : Form
    {
        
       
       
        public EditCourse()
        {
            InitializeComponent();
        }

        public  void EditCourse_Load(object sender, EventArgs e)
        {
            using(DatabaseContext db = new DatabaseContext()) 
            {
                comboBoxID.DataSource = db.courses.ToList();
                comboBoxID.DisplayMember= "label";
                comboBoxID.ValueMember = "IDcourse";

                comboBoxID.SelectedItem = null;
               

            }
          
          
        }
        public void fillCombo(int index)
        {

            using (DatabaseContext db = new DatabaseContext())
            {
                comboBoxID.DataSource = db.courses.ToList();
                comboBoxID.DisplayMember = "label";
                comboBoxID.ValueMember = "IDcourse";

                comboBoxID.SelectedItem = index;

            }

        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                
                if (comboBoxID.SelectedValue != null)
                {
                    DatabaseContext db = new DatabaseContext();
                    
                    string id = comboBoxID.SelectedValue.ToString();
                    var course = db.courses.Find(id);
                    if (course != null)
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("label", typeof(string));
                        table.Columns.Add("period", typeof(int));
                        table.Columns.Add("description", typeof(string));

                        table.Rows.Add(course.label, course.period, course.description);

                        textBoxLabel.Text = course.label;
                        numericUpDown1.Value = course.period;
                        richTextBoxDescription.Text = course.description;
                        comboBoxSemester.Text= course.semester;
                        
                        if(course.TeacherId!= null)
                        {

                            var Teacher=db.teachers.Find(course.TeacherId);
                            if (Teacher != null)
                            {
                                textBoxTearchLastName.Text = Teacher.fname+" "+Teacher.sname;
                            }
                        }
                        else
                        {
                            textBoxTearchLastName.Text = null;
                        }
                       
                    }
                }
               

               
            }
            catch  (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
          
            string label=textBoxLabel.Text;
            int hrs=(int)numericUpDown1.Value;
            string des=richTextBoxDescription.Text;
            string id=(string)comboBoxID.SelectedValue;

            using(DatabaseContext db= new DatabaseContext())
            {
               /* if (db.courses.Where(c => c.label == label).Count() > 0)
                {
                    MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }*/

                var cs = db.courses.Find(id);
                cs.description = des;
                cs.label = label;
                cs.period = hrs;
                if (FormTeacherList.idteacher != -1)
                {
                    cs.TeacherId = FormTeacherList.idteacher;
                }
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure Edit this course", "Edit Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.SaveChanges();

                        MessageBox.Show("This Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                   




                    













                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                
            }
            
        }

        private void buttonSelectTeacher_Click(object sender, EventArgs e)
        {
            FormTeacherList formTeacherList= new FormTeacherList();


            formTeacherList.Show(this);
            textBoxTearchLastName.Text = FormTeacherList.tearchFullname;




        }

        private void textBoxTearchLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
