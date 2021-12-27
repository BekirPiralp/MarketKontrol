using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMDefoService : LMBusinessRepositoryBaseService<Defo,ILMDefoDal,LMDefoValidator>,ILMDefoService
    {       
        public LMDefoService(ILMDefoDal defoDal):base(defoDal)
        {
        }
    }
}
