using Entity.Concrete;
using System.Collections.Generic;

namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommands
    {

        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }

    }
}
