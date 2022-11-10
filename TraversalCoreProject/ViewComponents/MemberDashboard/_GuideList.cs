using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            GuideManager guideManager = new GuideManager(new EfGuideDal());

            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
