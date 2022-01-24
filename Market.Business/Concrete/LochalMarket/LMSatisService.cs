using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMSatisService:LMBusinessRepositoryBaseService<Satis,ILMSatisDal,LMSatisValidator>,ILMSatisService
    {
        public LMSatisService(ILMSatisDal satisDal):base(satisDal)
        {

        }

        public Satis GetByBarkodFisKod(Bayi bayi, Firma firma, Urun urun, Fis fis)
        {
            Satis satis = null;
            try
            {
                if ( bayi != null && firma != null && urun != null && fis != null &&
                          bayi.Id > 0 && firma.Id > 0 && urun.Id > 0 && fis.Id > 0)
                {
                    satis = _entityDal.Get(p =>
                    (p.Bayi == bayi.Id && p.Firma == firma.Id && p.Fis == fis.Id && p.Urun == urun.Id));
                }
            }
            catch (Exception hata)
            {
                throw new Exception("Satis bilgisi getirmede hata ile karşılaşıldı. Hata :\n" + hata.Message);
            }
            return satis;
        }
    }
}
