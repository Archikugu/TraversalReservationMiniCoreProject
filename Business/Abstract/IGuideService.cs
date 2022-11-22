using Entity.Concrete;

namespace Business.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        void TChangeToEnableByGuide(int id);
        void TChangeToDisableByGuide(int id);
    }
}
