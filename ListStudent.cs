using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Day02
{
    public partial class ListStudent : Form
    {
        public ListStudent()
        {
            InitializeComponent();
        }

        private void ListStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet2.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter6.Fill(this.studentDBDataSet2.students);
            // TODO: This line of code loads data into the 'student_mangementDataSet.students' table. You can move, or remove it, as needed.
            DatabaseContext context = new DatabaseContext();
            context.students.Load();
            this.dataGridView1.DataSource = context.students.Local.ToBindingList();


            // TODO: This line of code loads data into the 'window_studentManagementDataSet3.students' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'window_studentManagementDataSet1.students' table. You can move, or remove it, as needed.


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdataStudent upStd = new UpdataStudent();
            upStd.IDtextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            upStd.Show(this);


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            UpdataStudent updataStudentupStd = new UpdataStudent();
            updataStudentupStd.IDtextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updataStudentupStd.Show(this);
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter6.Fill(this.studentDBDataSet2.students);
            // TODO: This line of code loads data into the 'student_mangementDataSet.students' table. You can move, or remove it, as needed.
            DatabaseContext context = new DatabaseContext();
            context.students.Load();
            this.dataGridView1.DataSource = context.students.Local.ToBindingList();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            

            using (DatabaseContext context = new DatabaseContext())
            {
              
               
                if (string.IsNullOrEmpty(findComboBox.Text))
                {
                    MessageBox.Show("Please choose attribute to filter");
                    return;
                }    
                if (findComboBox.Text == "First name")
                {
                    if(string.IsNullOrEmpty(findTextBox.Text))
                    {
                        MessageBox.Show("Pleast enter data to filter");
                    } 
                    else
                    {
                        try
                        {

                            if (radioButtonFemale.Checked)
                            {
                                var filteredData = context.students.Where(f => f.firstName.ToLower() == findTextBox.Text.ToLower() && f.gender=="Female").ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }
                            }
                            else if (radioButtonMale.Checked)
                            {
                                var filteredData = context.students.Where(f => f.firstName.ToLower() == findTextBox.Text.ToLower() && f.gender == "Male").ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }

                            }
                            else if(radioButtonNo.Checked)
                            {
                                var filteredData = context.students.Where(f => f.firstName.ToLower() == findTextBox.Text.ToLower()).ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }

                            }


                        }

                        catch
                        {
                            MessageBox.Show("Fail filter!!!");
                        }
                    }    
                    
                }
                else if(findComboBox.Text=="Last name")
                {
                    if (string.IsNullOrEmpty(findTextBox.Text))
                    {
                        MessageBox.Show("Pleast enter data to filter");
                    }
                    else
                    {
                        try
                        {

                            if (radioButtonFemale.Checked)
                            {
                                var filteredData = context.students.Where(f => f.lastName.ToLower() == findTextBox.Text.ToLower() && f.gender == "Female").ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }
                            }
                            else if (radioButtonMale.Checked)
                            {
                                var filteredData = context.students.Where(f => f.lastName.ToLower() == findTextBox.Text.ToLower() && f.gender == "Male").ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }

                            }
                            else if (radioButtonNo.Checked)
                            {
                                var filteredData = context.students.Where(f => f.lastName.ToLower() == findTextBox.Text.ToLower()).ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }

                            }


                        }

                        catch
                        {
                            MessageBox.Show("Fail filter!!!");
                        }
                    }
                    
                }
                else if (findComboBox.Text == "Address")
                {
                    if (string.IsNullOrEmpty(findTextBox.Text))
                    {
                        MessageBox.Show("Pleast enter data to filter");
                    }
                    else
                    {
                        try
                        {

                            if (radioButtonFemale.Checked)
                            {
                                var filteredData = context.students.Where(f => f.address.ToLower().Contains( findTextBox.Text.ToLower()) && f.gender == "Female").ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }
                            }
                            else if (radioButtonMale.Checked)
                            {
                                var filteredData = context.students.Where(f => f.address.ToLower().Contains(findTextBox.Text.ToLower()) && f.gender == "Male").ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }

                            }
                            else if (radioButtonNo.Checked)
                            {
                                var filteredData = context.students.Where(f => f.address.ToLower().Contains(findTextBox.Text.ToLower())).ToList();
                                if (filteredData.Count() > 0)
                                {
                                    this.dataGridView1.DataSource = filteredData;
                                }
                                else
                                {
                                    MessageBox.Show("Don't exist data");
                                }

                            }


                        }

                        catch
                        {
                            MessageBox.Show("Fail filter!!!");
                        }
                    }

                }


            }
        }

        private void noFilterBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            context.students.Load();
            this.dataGridView1.DataSource = context.students.Local.ToBindingList();
        }

        private void findComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
