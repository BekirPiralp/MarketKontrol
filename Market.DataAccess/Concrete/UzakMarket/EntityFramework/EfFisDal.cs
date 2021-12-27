using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;

namespace Market.DataAccess.Concrete.UzakMarket.EntityFramework
{
    public class EfFisDal : EfEntityRepositoryBase<Fis, UzakMarketContext>, IUMFisDal
    {
    }
}
