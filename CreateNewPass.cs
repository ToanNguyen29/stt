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
    public partial class CreateNewPass : Form
    {
        public string username;
        public CreateNewPass()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                if(string.IsNullOrEmpty(newPassTextBox.Text)|| string.IsNullOrEmpty(rePassTextBox.Text))
                {
                    MessageBox.Show("Please enter full information");
                    return;
                }
                if (newPassTextBox.Text.Length < 8)
                {
                    newPassTextBox.Text = "";
                    MessageBox.Show("Password must be at least 8 characters");
                    return;
                }

                if (String.Compare(newPassTextBox.Text, rePassTextBox.Text, false) != 0)
                {
                    rePassTextBox.Text = "";
                    MessageBox.Show("Don't verify retype password");
                    return;

                }

                try
                {
                    teacher man = context.teachers.Where(f => f.email == username).FirstOrDefault();
                    man.password = newPassTextBox.Text;
                    context.SaveChanges();
                    MessageBox.Show("Change password completed!!!");
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Fail reset!!!");
                }

            }
        }
    }
}
