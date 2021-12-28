using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMUrunService : UMBusinessRepositoryBaseService<Urun, IUMUrunDal, UMUrunValidator>, IUMUrunService
    {
        public UMUrunService(IUMUrunDal urunDal):base(urunDal)
        {

        }
    }
}
