using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        public IActionResult NewReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }
    }
}
