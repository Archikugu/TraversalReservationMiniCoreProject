using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SignUp() 
        //{
        //    return View();
        //}
        
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

    }
}
