using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMFotografService : UMBusinessRepositoryBaseService<Fotograf, IUMFotografDal, UMFotografValidator>, IUMFotografService
    {
        public UMFotografService(IUMFotografDal fotografDal):base(fotografDal)
        {

        }

        public Fotograf GetByPersonelId(int Id)
        {
            return this._entityDal.Get(p => p.Personel == Id);
        }
    }
}
