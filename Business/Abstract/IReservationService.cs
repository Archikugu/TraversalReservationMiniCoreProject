using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByApproved(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
