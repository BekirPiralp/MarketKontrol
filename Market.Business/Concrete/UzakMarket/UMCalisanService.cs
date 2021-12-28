using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMCalisanService : UMBusinessRepositoryBaseService<Calisan, IUMCalisanDal, UMCalisanValidator>, IUMCalisanService
    {
        public UMCalisanService(IUMCalisanDal calisanDal) : base(calisanDal)
        {

        }
    }
}
