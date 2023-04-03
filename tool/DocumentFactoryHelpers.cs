using Day02.tool;
using System;

internal static class DocumentFactoryHelpers
{
    public static IDocument CreateDocument(string format)
    {
        if (format == "PDF")
        {
            return new PdfDocument();
        }
        else if (format == "Excel")
        {
            return new ExcelDocument();
        }
        else if (format == "Word")
        {
            return new WordDocument();
        }
        else
        {
            throw new ArgumentException("Unsupported document format.");
        }
    }
}