using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02.tool
{
    internal class PdfDocument : IDocument
    {
        public void Print(DataGridView dataGridView)
        {

           // Create a new SaveFileDialog instance
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save PDF file";
            /* saveFileDialog.ShowDialog();*/

            // If the user clicked OK in the dialog box
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name and directory
                string fileName = saveFileDialog.FileName;

                // Create a new PDF document
                var pdfDoc = new Document();

               
                
                 pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4);
                

                // Create a new PDF writer
                var writer = PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));

                // Open the PDF document
                pdfDoc.Open();

                // Add a table to the PDF document
                var pdfTable = new PdfPTable(dataGridView.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Add the column headers to the table
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    pdfTable.AddCell(dataGridView.Columns[i].HeaderText);
                }

                // Add the data from the DataGridView to the table
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        pdfTable.AddCell(dataGridView.Rows[i].Cells[j].Value.ToString());
                    }
                }

                // Add the table to the PDF document
                pdfDoc.Add(pdfTable);

                // Close the PDF document
                pdfDoc.Close();

                // Open the PDF file in the default PDF viewer
                System.Diagnostics.Process.Start(fileName);
            }
        }
    
    }
}
