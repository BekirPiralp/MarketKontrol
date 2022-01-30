using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMMudurService : UMBusinessRepositoryBaseService<Mudur, IUMMudurDal, UMMudurValidator>, IUMMudurService
    {
        public UMMudurService(IUMMudurDal mudurDal):base(mudurDal)
        {

        }

        public Mudur GetByPersonelId(int Id)
        {
            Mudur result = null;
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

        public Mudur GetByPersonelId(int Id, int FirmaId)
        {
            Mudur result = null;
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

        public Mudur GetByBayi(int bayiId, int firmaId)
        {
            Mudur result = null;
            try
            {
                if (bayiId > 0 && firmaId > 0)
                    result = _entityDal.Get(p => p.Bayi == bayiId && p.Firma == firmaId);
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
