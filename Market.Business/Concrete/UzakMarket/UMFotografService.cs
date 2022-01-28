using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMFotografService : UMBusinessRepositoryBaseService<Fotograf, IUMFotografDal, UMFotografValidator>, IUMFotografService
    {
        public UMFotografService(IUMFotografDal fotografDal):base(fotografDal)
        {

        }

        public Fotograf GetByPersonelId(int Id)
        {
            Fotograf result = null;
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

        public Fotograf GetByPersonelId(int Id, int FirmaId)
        {
            Fotograf result = null;
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
