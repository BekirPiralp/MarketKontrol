using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMFisService : LMBusinessRepositoryBaseService<Fis,ILMFisDal,LMFisValidator>,ILMFisService
    {
        public LMFisService(ILMFisDal fisDal):base(fisDal)
        {

        }

        public Fis GetByDateTime(Firma firma, Bayi bayi, Personel personel, DateTime dateTime)
        {
            Fis fis = null;
            if (firma != null && bayi != null && personel != null && dateTime != null &&
                firma.Id > 0 && bayi.Id > 0 && personel.Id > 0 && dateTime.Year > 0)
            {
                try
                {
                    fis = _entityDal.Get(p => (p.Firma == firma.Id && p.Bayi == bayi.Id &&
                    p.Personel == personel.Id && p.TarihSaat == dateTime));
                }
                catch (Exception e)
                {

                    throw new Exception("Fiş bulmada hata oluştu lütfen kontrol edin. Hata:\n" + e.Message);
                }
            }
            return fis;
        }

        public Fis GetByFisKod(string FisKod)
        {
            Fis fis = null;
            try
            {
                if (FisKod.Trim() != "")
                {
                    fis = _entityDal.Get(p => (p.Kod.Trim().Equals(FisKod.Trim())));
                }
            }
            catch (Exception hata)
            {
                throw new Exception("Fis getirme sırasında hata ile karşılaşıldı. Hata : \n"+hata.Message);
            }
            return fis;
        }
    }
}
