
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
    public partial class AddStudentForm : Form
    {
        string[] checkUser = { "fuck", "Nigger", "Twat", "Ass" };
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
               DatabaseContext context = new DatabaseContext();

                if (string.IsNullOrEmpty(IDtextBox.Text) || string.IsNullOrEmpty(FNametextBox.Text) || string.IsNullOrEmpty(LNametextBox.Text) || string.IsNullOrEmpty(BirthdateTimePicker.Text) || string.IsNullOrEmpty(PhonetextBox.Text) || string.IsNullOrEmpty(EmailtextBox.Text) || string.IsNullOrEmpty(MajortextBox.Text) || string.IsNullOrEmpty(AddressrichTextBox.Text) || (MaleradioButton.Checked == false && FemaleradioButton.Checked==false))
                {
                    MessageBox.Show("Please enter all information");
                    return;
                }

                if (CheckInput.checkAlphabeticCharacters(FNametextBox.Text) == false)
                {

                    MessageBox.Show("Your first name has invalid characters");
                    return;
                }
                else
                {
                    for (int i = 0; i < checkUser.Length; i++)
                    {
                        if (String.Compare(FNametextBox.Text, checkUser[i], true) == 0)
                        {
                            MessageBox.Show("First name is a sensetive word");
                            FNametextBox.Text = "";
                            return;
                        }

                    }
                }
                if (CheckInput.checkAlphabeticCharacters(LNametextBox.Text) == false)
                {

                    MessageBox.Show("Your first name has invalid characters");
                    return;
                }
                else
                {
                    for (int i = 0; i < checkUser.Length; i++)
                    {
                        if (String.Compare(LNametextBox.Text, checkUser[i], true) == 0)
                        {
                            MessageBox.Show("Last name is a sensetive word");
                            LNametextBox.Text = "";
                            return;
                        }

                    }
                }

                if (CheckInput.checkEmailIsValid(EmailtextBox.Text) == false)
                {
                    MessageBox.Show("Email is invalid");
                    return;
                }

                if (CheckInput.IsPhoneNbr(PhonetextBox.Text) == false)
                {
                    MessageBox.Show("Phone number is invalid");
                    return;
                }

                if(CheckInput.CheckYear(BirthdateTimePicker.Text)==false)
                {
                    MessageBox.Show("Student is invalid age");
                    return;
                }

                if(PicturepictureBox==null)
                {
                    MessageBox.Show("Please choose picture");
                    return;
                }

                string a = "";
                if (MaleradioButton.Checked == true)
                {
                    a = "Male";
                }
                else
                {
                    a = "Female";
                }

                var s1 = new student
                {
                    mssv = IDtextBox.Text,
                    firstName = FNametextBox.Text,
                    lastName = LNametextBox.Text,
                    birthDay = BirthdateTimePicker.Value.Date,
                    phone = PhonetextBox.Text,
                    email = EmailtextBox.Text,
                    pirture = converterDemo(PicturepictureBox.Image),
                    major = MajortextBox.Text,
                    address = AddressrichTextBox.Text,
                    gender = a


                };
                try
                {
                    context.students.Add(s1);

                    context.SaveChanges();
                    MessageBox.Show("Add completed!!!");
                }
                catch(Exception)
                {
                    MessageBox.Show("cannot add!!");
                }
               



            }
            catch (Exception )
            {
                MessageBox.Show("cant");
            }
        }

        private void Canclebtn_Click(object sender, EventArgs e)
        {

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (.jpg;.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PicturepictureBox.Image = new Bitmap(opnfd.FileName);
            }

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void BirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
