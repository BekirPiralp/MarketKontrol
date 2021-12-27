using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    public interface IUMFisDal :IFisDal,IUMEntityRepository<Fis>
    {
    }
}
