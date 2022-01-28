using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMPersonelService : LMBusinessRepositoryBaseService<Personel,ILMPersonelDal,LMPersonelValidator>,ILMPersonelService
    {
        public LMPersonelService(ILMPersonelDal personelDal):base(personelDal)
        {

        }

        public Personel GetByTc(string Tc)
        {
            Personel result = null;
            try
            {
                result = _entityDal.Get(p => p.Tc.Equals(Tc.Trim()));
            }
            catch (Exception hata)
            {
                throw new Exception("Personel getirilirken hata oluştu. Hata: \n" + hata.Message);
            }
            return result;
        }
    }
}
