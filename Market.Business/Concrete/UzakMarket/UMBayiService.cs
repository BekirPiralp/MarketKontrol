using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMBayiService : UMBusinessRepositoryBaseService<Bayi, IUMBayiDal, UMBayiValidator>, IUMBayiService
    {
        public UMBayiService(IUMBayiDal bayiDal) : base(bayiDal)
        {

        }

        public List<Bayi> GetAllByFirma(Firma firma)
        {
            List<Bayi> result = null;
            try
            {
                if (firma != null && firma.Id > 0)
                    result = _entityDal.GetAll(p => p.Firma == firma.Id);
                else
                    throw new Exception("Firma bilgisi tam gelmediği için verileri getiremiyoruz.");
            }
            catch (Exception hata)
            {
                throw new Exception("Bayiler getirilirken hata oluştu. Hata: \n" + hata.Message);
            }

            return result;
        }

        public Bayi GetByAd(string Ad,Firma firma)
        {
            Bayi result = null;
            try
            {
                if (Ad.Trim() != "" && firma != null && firma.Id > 0)
                {
                    result = _entityDal.Get(p => p.BayiAd.ToLower().Trim().Equals(Ad.ToLower().Trim()) && p.Firma == firma.Id);
                }
                else
                    throw new Exception("Lütfen gerekli bilgileri tam veriniz.");
            }
            catch (Exception hata)
            {
                throw new Exception("Bayi verisi getirilirken hata oluştu. Hata:\n"+hata.Message);
            }
            return result;
        }
    }
}
