using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfFeaureDal : GenericRepository<Feature>, IFeatureDal
    {
    }
}
