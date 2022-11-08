using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByApproved(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "approved" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "previous reservation" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "waiting for approval" && x.AppUserId == id).ToList();
            }
        }
    }
}
