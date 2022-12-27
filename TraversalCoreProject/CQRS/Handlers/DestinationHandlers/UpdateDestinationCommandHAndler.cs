using DataAccess.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command) 
        {
            var values = _context.Destinations.Find(command.DestinationId);
            values.City = command.City;
            values.DayNight=command.DayNight;
            values.Price= command.Price;
            values.Capacity= command.Capacity;

            _context.SaveChanges();
        }
    }
}
