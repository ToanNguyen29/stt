
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Net.NetworkInformation;
using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Image = System.Drawing.Image;

namespace Day02
{
    public partial class Print_and_save : Form
    {
        public Print_and_save()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Print_and_save_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet3.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentDBDataSet3.students);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            /* if(radioButtonAll.Checked)
             {
                 radioButtonFemale.Checked = false;
                 radioButtonMale.Checked = false;
             }
             if (radioButtonFemale.Checked)
             {
                 radioButtonAll.Checked=false;


                 radioButtonMale.Checked = false;
             }
             if (radioButtonMale.Checked)
             {
                 radioButtonFemale.Checked = false;
                 radioButtonAll.Checked = false;
             }*/

            if (radioButtonYes.Checked == true)
            {
                DateTime fromTime = dateTimePickerFrom.Value;
                DateTime toTime = dateTimePickerTo.Value;
                if (fromTime > toTime)
                {
                    MessageBox.Show("you should pick fromTime < toTime ");
                }
                else
                {
                    using (DatabaseContext db = new DatabaseContext())
                    {


                        if (radioButtonAll.Checked == true)
                        {
                            var studentList = db.students.Where(s => s.birthDay > fromTime && s.birthDay < toTime).ToList();
                            if (studentList.Count() <= 0)
                            {
                                MessageBox.Show("Don't exist data");
                            }
                            else
                            {
                                this.dataGridView1.DataSource = studentList;
                            }
                        }
                        else if (radioButtonFemale.Checked == true)
                        {
                            var studentList = db.students.Where(s => s.birthDay > fromTime && s.birthDay < toTime && s.gender == "Female").ToList();
                            if (studentList.Count() <= 0)
                            {
                                MessageBox.Show("Don't exist data");
                            }
                            else
                            {
                                this.dataGridView1.DataSource = studentList;
                            }

                        }
                        else
                        {
                            var studentList = db.students.Where(s => s.birthDay > fromTime && s.birthDay < toTime && s.gender == "Male").ToList();
                            if (studentList.Count() <= 0)
                            {
                                MessageBox.Show("Don't exist data");
                            }
                            else
                            {
                                this.dataGridView1.DataSource = studentList;
                            }

                        }



                    }


                }

            }
            else
            {
                using (DatabaseContext db = new DatabaseContext())
                {


                    if (radioButtonAll.Checked == true)
                    {
                        var studentList = db.students.ToList();
                        if (studentList.Count() > 0)
                        {
                            this.dataGridView1.DataSource = studentList;
                        }
                        else
                        {
                            MessageBox.Show("Don't exist data");
                        }
                    }
                    else if (radioButtonFemale.Checked == true)
                    {
                        List<student> studentList = db.students.Where(s => s.gender == "Female").ToList();
                        if (studentList.Count() > 0)
                        {
                            this.dataGridView1.DataSource = studentList;
                        }
                        else
                        {
                            MessageBox.Show("Don't exist data");
                        }

                    }
                    else
                    {
                        List<student> studentList = db.students.Where(s => s.gender == "Male").ToList();
                        if (studentList.Count() > 0)
                        {
                            this.dataGridView1.DataSource = studentList;
                        }
                        else
                        {
                            MessageBox.Show("Don't exist data");
                        }

                    }
                }

            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {

            if (dataGridView1.Rows.Count != 0)
            {
                int RowCount = dataGridView1.Rows.Count;
                int ColumnCount = dataGridView1.Columns.Count;

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + dataGridView1.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    /*
                                        byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[7].Value;
                                        MemoryStream ms = new MemoryStream(imgbyte);*/

                    object cellValue = dataGridView1.Rows[r].Cells[7].Value;
                    if (cellValue is Bitmap)
                    {
                        Bitmap sparePicture = (Bitmap)cellValue;
                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                        Clipboard.SetDataObject(finalPic);
                        var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                        oPara2.Range.Paste();
                        oPara2.Range.InsertParagraphAfter();
                    }
                    else
                    {
                        Bitmap sparePicture = (Bitmap)((new ImageConverter()).ConvertFrom(cellValue));
                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                        Clipboard.SetDataObject(finalPic);
                        var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                        oPara2.Range.Paste();
                        oPara2.Range.InsertParagraphAfter();
                    }
                    /*                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);*/


                    //oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void buttonSavetoFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Word Documents (.docx)|.docx";
                saveFile.FileName = "export.docx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGridView1, saveFile.FileName);
                }
                else
                {
                    MessageBox.Show("No Record to export ");
                }
            }
        }





    }
}
