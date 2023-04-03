using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Day02.model;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Day02
{
    public partial class SignIn : Form
    {
        bool checkAccount = true;
        string err;
        string err1;
        string[] checkUser = { "fuck", "Nigger", "Twat", "Ass" };
        public SignIn()
        {
            InitializeComponent();
        }

        

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FNameTextBox.Text) || string.IsNullOrEmpty(SNameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(userTextBox.Text) || string.IsNullOrEmpty(PassTextBox.Text) || string.IsNullOrEmpty(rePassTextBox.Text))
            {
                MessageBox.Show("Please enter all information");
                return;
            }

            if (CheckInput.checkAlphabeticCharacters(FNameTextBox.Text) == false)
            {

                MessageBox.Show("Your first name has invalid characters");
                return;
            }
            else
            {
                for (int i = 0; i < checkUser.Length; i++)
                {
                    if (String.Compare(FNameTextBox.Text, checkUser[i], true) == 0)
                    {
                        MessageBox.Show("First name is a sensetive word");
                        FNameTextBox.Text = "";
                        return;
                    }

                }

            }

            if (CheckInput.checkAlphabeticCharacters(SNameTextBox.Text) == false)
            {

                MessageBox.Show("your surname has invalid characters");
                return;
            }
            else
            {
                for (int i = 0; i < checkUser.Length; i++)
                {
                    if (String.Compare(SNameTextBox.Text, checkUser[i], true) == 0)
                    {
                        MessageBox.Show("Surname is a sensetive word");
                        SNameTextBox.Text = "";
                        return;
                    }
                }
            }

            if (CheckInput.checkEmailIsValid(emailTextBox.Text) == false)
            {
                MessageBox.Show("Email is invalid");
                return;
            }

            if (CheckInput.IsPhoneNbr(phoneTextBox.Text) == false)
            {
                MessageBox.Show("Phone number is invalid");
                return;
            }

            if ( PassTextBox.Text.Length < 8)
            {
                PassTextBox.Text = "";
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            if(String.Compare(PassTextBox.Text, rePassTextBox.Text, false)!=0)
            {
                rePassTextBox.Text = "";
                MessageBox.Show("Don't verify retype password");
                return;
                
            }  

            
                
                if(checkAccount==false)
                {
                    MessageBox.Show("user_name already exists!!");
                    return;
                        
                }
                else
                {
                    DatabaseContext databaseContext = new DatabaseContext();
                    teacher mn = new teacher
                    {
                        
                        password = PassTextBox.Text,
                        fname = FNameTextBox.Text,
                        sname = SNameTextBox.Text,
                        email = emailTextBox.Text,
                        phone = phoneTextBox.Text
                    };
                    try
                    {
                        databaseContext.teachers.Add(mn);

                        databaseContext.SaveChanges();
                        MessageBox.Show("Add completed!!!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("cannot add!!");
                    }


                }
                

            }

            catch(Exception)
            {
                MessageBox.Show("Create failed");
            }
        }

        private void FNameTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void PassTextBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void SNameTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
           using(DatabaseContext databaseContext = new DatabaseContext())
            {
                var checkuser = databaseContext.teachers.Where(t => t.email== userTextBox.Text && t.password == PassTextBox.Text).ToList();

                if (checkuser.Count>0)
                {
                    MessageBox.Show("user_name already exists!!");
                    checkAccount = false;

                }
            }
            
            
        }

        private void rePassTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
