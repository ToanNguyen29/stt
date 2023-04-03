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
    public partial class FindAccount : Form
    {
        public FindAccount()
        {
            InitializeComponent();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                try
                {
                    teacher man = context.teachers.Where(f => f.email == UseNameRichTextBox.Text).FirstOrDefault();
                    if (man == null)
                    {
                        MessageBox.Show("Account doesn't exist");
                    }
                    else
                    {
                        SendCode sc = new SendCode();
                        sc.SendCodeLable.Text = man.email;
                        sc.username = UseNameRichTextBox.Text;
                        sc.Show(this);
                        
                    }
                    


                }
                catch
                {
                    MessageBox.Show("Fail reset!!!");
                }

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
    
}
