using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMFisService : UMBusinessRepositoryBaseService<Fis, IUMFisDal, UMFisValidator>, IUMFisService
    {
        public UMFisService(IUMFisDal fisDal):base(fisDal)
        {

        }

        public Fis GetByDateTime(Firma firma, Bayi bayi, Personel personel, DateTime dateTime)
        {
            Fis fis = null;
            if(firma != null && bayi != null && personel != null && dateTime != null &&
                firma.Id > 0  && bayi.Id > 0 && personel.Id > 0 && dateTime.Year > 0)
            {
                try
                {
                    fis = _entityDal.Get(p => (p.Firma == firma.Id && p.Bayi == bayi.Id &&
                    p.Personel == personel.Id && p.TarihSaat == dateTime));
                }
                catch(Exception e)
                {

                    throw new Exception("Fiş bulmada hata oluştu lütfen kontrol edin. Hata:\n" + e.Message);
                }
            }
            return fis;
        }
    }
}
