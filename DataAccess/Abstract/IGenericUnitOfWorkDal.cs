using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericUnitOfWorkDal<T>where T : class
    {
        void Insert(T t);
        void Update(T t);
        void MultiUpdate(List<T> t);

        T GetById(int id);
        
    }
}
