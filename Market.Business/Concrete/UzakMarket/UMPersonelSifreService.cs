using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMPersonelSifreService : UMBusinessRepositoryBaseService<PersonelSifre, IUMPersonelSifreDal, UMPersonelSifreValidator>, IUMPersonelSifreService
    {
        public UMPersonelSifreService(IUMPersonelSifreDal personelSifreDal) : base(entityDal: personelSifreDal)
        {

        }

        public PersonelSifre GetByPersonelId(int Id)
        {
            return this._entityDal.Get(p => p.Personel == Id);
        }
    }
}
