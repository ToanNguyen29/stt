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
    public partial class LoginForm : Form
    {
        string err;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            

            string username = userTextBox.Text;
            string password = PassTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;

            }

            else
            {
                var checkuser = databaseContext.teachers.Where(t => t.email == username && t.password == password).ToList();


                // Check if the username and password are correct
                if (checkuser.Count>0)
                {

                    // Login successful, show the main form
                    mainForm mainFormm = new mainForm();
                    mainFormm.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInLable_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.Show();
            
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void forgetPassLable_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                try
                {
                    teacher man = context.teachers.Where(f => f.email == userTextBox.Text).FirstOrDefault();
                    if(man != null)
                    {
                        SendCode sc = new SendCode();
                        sc.SendCodeLable.Text = man.email;
                        sc.username = userTextBox.Text;
                        sc.Show(this);
                    }
                    else
                    {
                        FindAccount fa = new FindAccount();
                        fa.Show(this);                   
                    }
                    
                    

                }
                catch
                {
                    MessageBox.Show("Fail reset!!!");
                }

            }
        }
    }
}
