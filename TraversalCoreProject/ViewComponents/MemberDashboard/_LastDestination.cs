using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _LastDestination : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestination(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetLastFourDestinations();
            return View(values);
        }
    }
}
