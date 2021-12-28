using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMSatisService : UMBusinessRepositoryBaseService<Satis, IUMSatisDal, UMSatisValidator>, IUMSatisService
    {
        public UMSatisService(IUMSatisDal satisDal):base(satisDal)
        {

        }
    }
}
