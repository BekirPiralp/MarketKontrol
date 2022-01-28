using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMCalisanService : UMBusinessRepositoryBaseService<Calisan, IUMCalisanDal, UMCalisanValidator>, IUMCalisanService
    {
        public UMCalisanService(IUMCalisanDal calisanDal) : base(calisanDal)
        {

        }

        public List<Calisan> GetAllByFirma(Firma firma)
        {
            List<Calisan> result = null;
            try
            {
                if (firma != null && firma.Id > 0)
                {
                    result = _entityDal.GetAll(p => (p.Firma == firma.Id));
                }
                else
                    throw new Exception("Gerekli olan firma bilgilerine ulaşılamadı.");
            }
            catch (Exception hata)
            {
                throw new Exception("Calisanlar getirilirken hata oluştu. Hata:\n" + hata.Message);
            }
            return result;
        }

        public List<Calisan> GetAllByFirmaBayi(Firma firma, Bayi bayi)
        {
            List<Calisan> result = null;
            try
            {
                if (firma != null && bayi != null && firma.Id > 0 && bayi.Id > 0 && firma.Id == bayi.Firma)
                {
                    result = _entityDal.GetAll(p => (p.Firma == firma.Id && p.Bayi == bayi.Id));
                }
                else
                    throw new Exception("Gerekli olan firma ve bayi bilgilerine ulaşılamadı.");
            }
            catch (Exception hata)
            {
                throw new Exception("Calisanlar getirilirken hata oluştu. Hata:\n"+hata.Message);
            }
            return result;
        }

        public Calisan GetByPersonelId(int Id)
        {
            Calisan result = null;
            try
            {
                if (Id > 0)
                    result = _entityDal.Get(p => p.Personel == Id);
                else
                    throw new Exception("Lütfen Verileri eksiksiz giriniz");
            }
            catch (Exception hata)
            {
                throw new Exception("Veriler getirilirken hata oluştu. Hata: \n" + hata.Message);
            }
            return result;
        }

        public Calisan GetByPersonelId(int Id, int FirmaId)
        {
            Calisan result = null;
            try
            {
                if (Id > 0 && FirmaId > 0)
                    result = _entityDal.Get(p => p.Personel == Id && p.Firma == FirmaId);
                else
                    throw new Exception("Lütfen Verileri eksiksiz giriniz");
            }
            catch (Exception hata)
            {
                throw new Exception("Veriler getirilirken hata oluştu. Hata: \n" + hata.Message);
            }
            return result;
        }
    }
}
