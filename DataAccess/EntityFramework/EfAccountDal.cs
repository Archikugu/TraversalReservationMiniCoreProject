using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfAccountDal : GenericUnitOfWorkRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {

        }
    }
}
