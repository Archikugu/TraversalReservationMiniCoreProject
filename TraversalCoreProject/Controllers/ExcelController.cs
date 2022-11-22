using Business.Abstract;
using ClosedXML.Excel;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationsList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Capacity = x.Capacity,
                    Price = x.Price
                }).ToList();
            }
            return destinationModels;
        }
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationsList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewExcel.xlsx");
        }
        public IActionResult DestinationExcelReport()
        {
            //using (var workBook = new XLWorkbook())
            //{
            //    var workSheet = workBook.Worksheets.Add("Destination List");
            //    workSheet.Cell(1, 1).Value = "City";
            //    workSheet.Cell(1, 2).Value = "Day Night";
            //    workSheet.Cell(1, 3).Value = "Capacity";
            //    workSheet.Cell(1, 4).Value = "Price";

            //    int rowCount = 2;
            //    foreach (var item in DestinationsList())
            //    {
            //        workSheet.Cell(rowCount, 1).Value = item.City;
            //        workSheet.Cell(rowCount, 2).Value = item.DayNight;
            //        workSheet.Cell(rowCount, 3).Value = item.Capacity;
            //        workSheet.Cell(rowCount, 4).Value = item.Price;
            //        rowCount++;

            //    }
            //    using (var stream = new MemoryStream())
            //    {
            //        workBook.SaveAs(stream);
            //        var content = stream.ToArray();
            //        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewList.xlsx");
            //    }
            //}

            return File(_excelService.ExcelList(DestinationsList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewList.xlsx");
        }
    }
}

