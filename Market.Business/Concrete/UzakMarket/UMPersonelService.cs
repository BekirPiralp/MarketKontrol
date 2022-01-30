using Market.Business.Abstract;
using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMPersonelService : UMBusinessRepositoryBaseService<Personel, IUMPersonelDal, UMPersonelValidator>, IUMPersonelService
    {
        public UMPersonelService(IUMPersonelDal personelDal):base(personelDal)
        {
            
        }

        public List<Personel> GetAllbyFirma(Firma firma)
        {
            List<Personel> result = null;
            try
            {
                if (firma != null && firma.Id > 0)
                {
                    result = _entityDal.GetAll(p => p.Firma == firma.Id);
                }
                else
                    throw new Exception("Firma bilgisini tam veriniz");
            }
            catch (Exception hata)
            {
                throw new Exception("Personeller getirilirken hata ile karşılaşıldı. Hata: \n"+hata.Message);
            }
            return result;
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
                throw new Exception("Personel getirilirken hata oluştu. Hata: \n"+hata.Message);
            }
            return result;
        }

        public Personel GetByTc(string Tc, Firma firma)
        {
            Personel result = null;
            try
            {
                if (Tc.Trim().Length == 11 && firma != null && firma.Id > 0)
                {
                    result = _entityDal.Get(p => p.Tc.Equals(Tc.Trim()) && p.Firma == firma.Id);
                }
                else
                    throw new Exception("Gerekli veri ler tam gelmediği için sorgu yapamıyoruz.");
            }
            catch (Exception hata)
            {
                throw new Exception("Personel getirilirken hata oluştu. Hata: \n" + hata.Message);
            }
            return result;
        }
    }
}
