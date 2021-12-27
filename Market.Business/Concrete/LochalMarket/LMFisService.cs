using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMFisService : LMBusinessRepositoryBaseService<Fis,ILMFisDal,LMFisValidator>,ILMFisService
    {
        public LMFisService(ILMFisDal fisDal):base(fisDal)
        {

        }
    }
}
