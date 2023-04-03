using System;
using System.IO;
using System.Windows.Forms;
using Day02.tool;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

public class ExcelDocument : IDocument
{
    public void Print(DataGridView dataGridView)
    {

        var excelApp = new Application();

        try
        {
            // Create a new SaveFileDialog instance
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Excel file";

            // If the user clicked OK in the dialog box
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name and directory
                string fileName = saveFileDialog.FileName;

                // Create a new Excel workbook
                var excelWorkbook = excelApp.Workbooks.Add();

                // Get the active worksheet
                var excelWorksheet = excelWorkbook.ActiveSheet;

                // Add the column headers to the worksheet
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    excelWorksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Add the data from the DataGridView to the worksheet
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        excelWorksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                /*  // Add the table to the PDF document
                  pdfDoc.Add(pdfTable);

                  // Close the PDF document
                  pdfDoc.Close();*/
                excelWorkbook.SaveAs(fileName);

                excelWorkbook.Close();

                // Open the PDF file in the default PDF viewer
                System.Diagnostics.Process.Start(fileName);

                /*// Save the Excel workbook
                excelWorkbook.SaveAs(fileName);

                // Print the Excel workbook to the default printer
                excelWorkbook.PrintOut();

                // Close the Excel workbook
                excelWorkbook.Close();

                // Quit the Excel application
                excelApp.Quit();*/
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Release the resources used by the Excel application
            if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }
}
    
