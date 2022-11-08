using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListWithReservationByApproved(int id)
        {
            return _reservationDal.GetListWithReservationByApproved(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
