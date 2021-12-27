using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMPersonelService : LMBusinessRepositoryBaseService<Personel,ILMPersonelDal,LMPersonelValidator>,ILMPersonelService
    {
        public LMPersonelService(ILMPersonelDal personelDal):base(personelDal)
        {

        }
    }
}
