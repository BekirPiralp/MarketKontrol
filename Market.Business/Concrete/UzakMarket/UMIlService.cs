using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMIlService : UMBusinessRepositoryBaseService<Il, IUMIlDal, UMIlValidator>, IUMIlService
    {
        public UMIlService(IUMIlDal ilDal):base(ilDal)
        {

        }
    }
}
