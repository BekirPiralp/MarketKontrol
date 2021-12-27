using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMDepoEkleUrunService : LMBusinessRepositoryBaseService<DepoEkleUrun,ILMDepoEkleUrunDal,LMDepoEkleUrunValidator>,ILMDepoEkleUrunService
    {
        public LMDepoEkleUrunService(ILMDepoEkleUrunDal depoEkleUrunDal):base(depoEkleUrunDal)
        {
            
        }
    }
}
