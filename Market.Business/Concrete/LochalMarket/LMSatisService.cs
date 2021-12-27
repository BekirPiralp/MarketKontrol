using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMSatisService:LMBusinessRepositoryBaseService<Satis,ILMSatisDal,LMSatisValidator>,ILMSatisService
    {
        public LMSatisService(ILMSatisDal satisDal):base(satisDal)
        {

        }
    }
}
