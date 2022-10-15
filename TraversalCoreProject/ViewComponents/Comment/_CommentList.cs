using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
