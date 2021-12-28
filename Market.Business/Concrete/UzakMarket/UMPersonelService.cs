using Market.Business.Abstract;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMPersonelService : UMBusinessRepositoryBaseService<Personel, IUMPersonelDal, UMPersonelValidator>, IPersonelService
    {
        public UMPersonelService(IUMPersonelDal personelDal):base(personelDal)
        {

        }
    }
}
