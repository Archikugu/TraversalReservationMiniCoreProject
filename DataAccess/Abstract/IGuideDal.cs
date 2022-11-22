using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGuideDal : IGenericDal<Guide>
    {
        void ChangeToEnableByGuide(int id);
        void ChangeToDisableByGuide(int id);
    }
}
