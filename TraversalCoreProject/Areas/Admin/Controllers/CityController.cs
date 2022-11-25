using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination); 
            return Json(values);
        }

        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.TGetByID(DestinationId);
            var jsonValues=JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            var values =_destinationService.TGetByID(destination.DestinationId);
            _destinationService.TUpdate(destination);
            var v=JsonConvert.SerializeObject(destination);
            return Json(v);
        }


        //Static City Class
        /*  public static List<CityClass> cities = new List<CityClass>
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
          };*/
    }
}
