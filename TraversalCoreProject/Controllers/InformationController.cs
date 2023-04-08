using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
