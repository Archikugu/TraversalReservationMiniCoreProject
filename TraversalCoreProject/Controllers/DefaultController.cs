using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
