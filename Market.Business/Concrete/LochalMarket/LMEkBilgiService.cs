using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMEkBilgiService : LMBusinessRepositoryBaseService<EkBilgi,ILMEkBilgiDal,LMEkBilgiValidator>,ILMEkBilgiService
    {
        public LMEkBilgiService(ILMEkBilgiDal ekBilgiDal):base(ekBilgiDal)
        {
                
        }
    }
}
