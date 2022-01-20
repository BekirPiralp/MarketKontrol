using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMPersonelSifreService : LMBusinessRepositoryBaseService<PersonelSifre,ILMPersonelSifreDal,LMPersonelSifreValidator>,ILMPersonelSifreService
    {
        public LMPersonelSifreService(ILMPersonelSifreDal personelSifreDal):base(personelSifreDal)
        {

        }

        public PersonelSifre GetByPersonelId(int Id)
        {
            return this._entityDal.Get(p => p.Personel==Id);
        }
    }
}
