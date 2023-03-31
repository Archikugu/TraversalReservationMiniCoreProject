using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLastFourDestinations();
    }
}
