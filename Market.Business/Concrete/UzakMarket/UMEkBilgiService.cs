using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMEkBilgiService : UMBusinessRepositoryBaseService<EkBilgi, IUMEkBilgiDal, UMEkBilgiValidator>, IUMEkBilgiService
    {
        public UMEkBilgiService(IUMEkBilgiDal ekBilgiDal) : base(ekBilgiDal)
        {

        }

        public EkBilgi GetByPersonelId(int Id)
        {
            EkBilgi result = null;
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

        public EkBilgi GetByPersonelId(int Id, int FirmaId)
        {
            EkBilgi result = null;
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
