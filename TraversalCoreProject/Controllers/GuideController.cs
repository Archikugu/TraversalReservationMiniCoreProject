using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IActionResult Index()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
