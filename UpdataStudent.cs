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
    public partial class UpdataStudent : Form
    {
        string temp = null;
        public UpdataStudent()
        {
            InitializeComponent();
        }

        private void LNametextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void find(string mssv,string temp)
        {
           
             using (DatabaseContext db=new DatabaseContext())
            {
               student std = db.students.Where(f => f.mssv == mssv).FirstOrDefault();
                if(std==null)
                {

                    IDtextBox.Text = temp;
                    MessageBox.Show("don't exist this student");
                  
                }
                else
                {
                    IDtextBox.Text = std.mssv;
                    FNametextBox.Text = std.firstName;
                    LNametextBox.Text = std.lastName;
                    PhonetextBox.Text = std.phone;
                    PicturepictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(std.pirture));
                    
                    if (std.gender=="Male")
                    {
                        MaleradioButton.Checked = true;
                    }
                    else
                    {
                        FemaleradioButton.Checked = true;
                    }

                    AddressrichTextBox.Text = std.address;
                    BirthdateTimePicker.Value = std.birthDay;
                    EmailtextBox.Text = std.email;
                    MajortextBox.Text = std.major;

                }
            }
        }
      
        private void findbtn_Click(object sender, EventArgs e)
        {
        
            find(IDtextBox.Text,temp);
        }

        private void UpdataStudent_Load(object sender, EventArgs e)
        {
            temp=IDtextBox.Text;
            find(IDtextBox.Text,temp);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            try
            {
                DatabaseContext context = new DatabaseContext();

                string a = "";
                if (MaleradioButton.Checked == true)
                {
                    a = "Male";
                }
                else
                {
                    a = "Female";
                }

                try
                {

                    student std = context.students.Where(f => f.mssv == IDtextBox.Text).FirstOrDefault();
                    
                    if (std == null)
                    {
                        IDtextBox.Text = temp;


                        MessageBox.Show("don't exist this student");

                    }
                    else
                    {
                        std.mssv = IDtextBox.Text;
                        std.firstName = FNametextBox.Text;
                        std.lastName = LNametextBox.Text;
                        std.birthDay = BirthdateTimePicker.Value.Date;
                        std.phone = PhonetextBox.Text;
                        std.email = EmailtextBox.Text;
                        std.pirture = AddStudentForm.converterDemo(PicturepictureBox.Image);
                        std.major = MajortextBox.Text;
                        std.address = AddressrichTextBox.Text;
                        std.gender = a;


                        context.SaveChanges();
                        MessageBox.Show("Add completed!!!");
                    }

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("cannot add!!");
                }




            }
            catch (Exception)
            {
                MessageBox.Show("cant");
            }
        }

        private void Canclebtn_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                try
                {
                    student std = context.students.Where(f => f.mssv == IDtextBox.Text).FirstOrDefault();
                    context.students.Remove(std);

                    context.SaveChanges();
                    MessageBox.Show("Delete completed!!!");
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Delete failed!!!");
                }
                
            }    
            
                
        }
    }
}
