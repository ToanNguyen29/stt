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
using System.Net;

namespace Day02
{
    public partial class SendCode : Form
    {
        public string username;
        string randomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (SendCodeLable.Text).ToString();
            from = "20110012@student.hcmute.edu.vn";
            pass = "toan2k22910@@@@@";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendCode_Load(object sender, EventArgs e)
        {

        }

        private void VerifyCodeBtn_Click(object sender, EventArgs e)
        {
            if (randomCode == (VerifyCodeTextBox.Text).ToString()) 
            {
                to = SendCodeLable.Text;
                CreateNewPass np = new CreateNewPass();
                np.username = username;
                this.Close();
                np.Show();
            }

            else
            {
                VerifyCodeTextBox.Text = "";
                MessageBox.Show("Wrong code");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FindAccount fa = new FindAccount();
            fa.Show(this);
            this.Close();
        }
    }
}
