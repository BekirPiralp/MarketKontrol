using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMUrunService : LMBusinessRepositoryBaseService<Urun,ILMUrunDal,LMUrunValidator>,ILMUrunService
    {
        public LMUrunService(ILMUrunDal urunDal):base(urunDal)
        {

        }
    }
}
