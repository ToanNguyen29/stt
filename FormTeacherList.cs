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
    public partial class FormTeacherList : Form
    {
        public static int idteacher = -1;
        public static string tearchFullname = "";
        public FormTeacherList()
        {
            InitializeComponent();
        }

        private void FormTeacherList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet5.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter1.Fill(this.studentDBDataSet5.teachers);
            // TODO: This line of code loads data into the 'studentDBDataSet4.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.studentDBDataSet4.teachers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTearcher_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewTearcher_DoubleClick_1(object sender, EventArgs e)
        {



            idteacher = int.Parse(dataGridViewTearcher.CurrentRow.Cells[0].Value.ToString());
            tearchFullname = dataGridViewTearcher.CurrentRow.Cells[1].Value.ToString() +" " +dataGridViewTearcher.CurrentRow.Cells[2].Value.ToString();

            this.Close();

        }

        private void dataGridViewTearcher_Click(object sender, EventArgs e)
        {
            idteacher = int.Parse(dataGridViewTearcher.CurrentRow.Cells[0].Value.ToString());
            tearchFullname = dataGridViewTearcher.CurrentRow.Cells[1].Value.ToString() + " "+ dataGridViewTearcher.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }

        private void dataGridViewTearcher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
