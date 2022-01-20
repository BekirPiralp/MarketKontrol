using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMYoneticiService : UMBusinessRepositoryBaseService<Yonetici, IUMYoneticiDal, UMYoneticiValidator>, IUMYoneticiService
    {
        public UMYoneticiService(IUMYoneticiDal yoneticiDal):base(yoneticiDal)
        {

        }

        public Yonetici GetByPersonelId(int Id)
        {
            return this._entityDal.Get(p => p.Personel == Id);
        }
    }
}
