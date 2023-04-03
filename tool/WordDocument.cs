using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSF;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Day02.tool
{
    public class WordDocument : IDocument
    {
        public void Print(DataGridView dataGridView)
        {

           // Create a new Word application
            var wordApp = new Application();

            // Declare the wordDoc variable at the beginning of the function
            Document wordDoc = null;

            try
            {
                // Create a new SaveFileDialog instance
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Word files (*.docx)|*.docx";
                saveFileDialog.Title = "Save Word file";

                // If the user clicked OK in the dialog box
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name and directory
                    string fileName = saveFileDialog.FileName;

                    // Create a new Word document
                    wordDoc = wordApp.Documents.Add();

                    // Add a table to the Word document
                    var wordTable = wordDoc.Tables.Add(wordDoc.Range(), dataGridView.Rows.Count, dataGridView.Columns.Count);
                    wordTable.Borders.Enable = 1;

                    // Add the column headers to the table
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        wordTable.Cell(1, i + 1).Range.Text = dataGridView.Columns[i].HeaderText;
                    }

                    // Add the data from the DataGridView to the table
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            wordTable.Cell(i + 2, j + 1).Range.Text = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Save the Word document
                    wordDoc.SaveAs2(fileName);

                    // Print the Word document to the default printer
                   /* wordDoc.PrintOut();*/

                    // Close the Word document
                    wordDoc.Close();

                    // Quit the Word application
                    wordApp.Quit();
                    System.Diagnostics.Process.Start(fileName);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Release the resources used by the Word application
                if (wordDoc != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                if (wordApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
        }
    }
}
    

