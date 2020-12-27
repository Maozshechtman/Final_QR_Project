using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PdfTest
    {
        //TODO: change the class name to PdfHandler
       public static void CreatePdf()
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            graph.DrawString("This is my first PDF document.Thank U !", font, XBrushes.Black,
            new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), 
            XStringFormats.TopLeft);

            pdf.Save("firstpage.pdf");

        }
    }
}
