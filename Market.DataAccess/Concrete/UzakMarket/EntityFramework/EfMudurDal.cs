using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
namespace Market.DataAccess.Concrete.UzakMarket.EntityFramework
{
    public class EfMudurDal : EfEntityRepositoryBase<Mudur, UzakMarketContext>, IUMMudurDal
    {
    }
}
