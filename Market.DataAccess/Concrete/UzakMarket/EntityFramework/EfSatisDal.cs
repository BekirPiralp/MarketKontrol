using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
namespace Market.DataAccess.Concrete.UzakMarket.EntityFramework
{
    public class EfSatisDal : EfEntityRepositoryBase<Satis,UzakMarketContext>, IUMSatisDal
    {
    }
}
