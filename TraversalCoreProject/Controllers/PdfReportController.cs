using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "file1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Reservation Pdf Reports");

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/file1.pdf", "application/pdf", "file1.pdf");
        }
        public IActionResult StaticCustomerReport() 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "file2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Member Name");
            pdfPTable.AddCell("Member LastName");
            pdfPTable.AddCell("Member Identity Number");

            pdfPTable.AddCell("Gokhan");
            pdfPTable.AddCell("Gok");
            pdfPTable.AddCell("12345678901");
 
            pdfPTable.AddCell("Gokhan");
            pdfPTable.AddCell("Gok");
            pdfPTable.AddCell("12345678901");
            
            pdfPTable.AddCell("Gokhan");
            pdfPTable.AddCell("Gok");
            pdfPTable.AddCell("12345678901");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/file2.pdf", "application/pdf", "file2.pdf");
        }
    }
}
