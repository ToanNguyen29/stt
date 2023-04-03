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
    public partial class StaticsForm : Form
    {
        Color panTotalColor;
        Color panMaleColor;
        Color paFemaleColor;
        public StaticsForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            double total, male,female;
            panMaleColor = panelTotal.BackColor;
            panMaleColor = panelMale.BackColor;
            paFemaleColor = PanelFemale.BackColor;
            using(DatabaseContext db =new DatabaseContext())
            {
                total = db.students.Count();
                male=db.students.Where(t=>t.gender=="Male").Count();
                female= db.students.Where(t => t.gender == "Female").Count();

            }

            double maleStudentPercentage = (male * (100 / total));
            double femaleStudentPercentage = (female * (100 / total));
            labelTotal.Text=("Total Students: "+total.ToString());
            LabelMale.Text= " Total male: "+maleStudentPercentage.ToString("0.00")+"%";   
            LabelFemale.Text= " Total female: " +femaleStudentPercentage.ToString("0.00")+"%";




        }

        private void panelTotal_Move(object sender, EventArgs e)
        {

        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = panTotalColor;
            panelTotal.BackColor=Color.White;
        }

        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor= panMaleColor;
            panelMale.BackColor=Color.White;
        }

        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = paFemaleColor;
            PanelFemale.BackColor=Color.White;
        }

        private void panelMale_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
