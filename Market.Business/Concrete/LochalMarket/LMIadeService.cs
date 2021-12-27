using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMIadeService : LMBusinessRepositoryBaseService<Iade,ILMIadeDal,LMIadeValidator>,ILMIadeService
    {
        public LMIadeService(ILMIadeDal iadeDal):base(iadeDal)
        {

        }
    }
}
