using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMBayiService : LMBusinessRepositoryBaseService<Bayi,ILMBayiDal,LMBayiValidator>,ILMBayiService
    {
        public LMBayiService(ILMBayiDal bayiDal):base(bayiDal)
        {
        }
    }
}
