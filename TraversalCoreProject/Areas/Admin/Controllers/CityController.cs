using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        }

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass ()
            {
                CityId= 1,
                CityName="Paris",
                CityCountry="France"
            },
            new CityClass ()
            {
                CityId= 2,
                CityName="Roma",
                CityCountry="Italy"
            },new CityClass ()
            {
                CityId= 3,
                CityName="London",
                CityCountry="England"
            },
        };
    }
}
