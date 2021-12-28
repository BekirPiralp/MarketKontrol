using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMIadeService : UMBusinessRepositoryBaseService<Iade, IUMIadeDal, UMIadeValidator>, IUMIadeService
    {
        public UMIadeService(IUMIadeDal iadeDal):base(iadeDal)
        {

        }
    }
}
