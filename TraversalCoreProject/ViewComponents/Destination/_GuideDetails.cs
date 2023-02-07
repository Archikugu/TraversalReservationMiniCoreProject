using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _GuideDetails:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetByID(1);
            return View(values);
        }
    }
}
