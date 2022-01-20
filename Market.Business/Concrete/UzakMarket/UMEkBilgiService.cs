using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMEkBilgiService : UMBusinessRepositoryBaseService<EkBilgi, IUMEkBilgiDal, UMEkBilgiValidator>, IUMEkBilgiService
    {
        public UMEkBilgiService(IUMEkBilgiDal ekBilgiDal) : base(ekBilgiDal)
        {

        }

        public EkBilgi GetByPersonelId(int Id)
        {
            return this._entityDal.Get(p => p.Personel == Id);
        }
    }
}
