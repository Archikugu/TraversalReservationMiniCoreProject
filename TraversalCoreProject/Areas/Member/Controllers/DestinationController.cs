using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
        public IActionResult GetCitiesSearcByName(string searchCity)
        {
            ViewData["CurrentFilter"] = searchCity;
            var values = from x in destinationManager.TGetList() select x;
            if (!string.IsNullOrEmpty(searchCity))
            {
                values = values.Where(y => y.City.Contains(searchCity));
            }
            return View(values.ToList());
        }
    }
}
