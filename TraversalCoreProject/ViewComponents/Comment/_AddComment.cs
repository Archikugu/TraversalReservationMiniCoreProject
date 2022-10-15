using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
