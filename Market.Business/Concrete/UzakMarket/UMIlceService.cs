using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMIlceService : UMBusinessRepositoryBaseService<Ilce, IUMIlceDal, UMIlceValidator>, IUMIlceService
    {
        public UMIlceService(IUMIlceDal ilceDal):base(ilceDal)
        {

        }
    }
}
