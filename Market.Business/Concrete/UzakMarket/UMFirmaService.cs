using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMFirmaService:UMBusinessRepositoryBaseService<Firma,IUMFirmaDal,UMFirmaValidator>,IUMFirmaService
    {
        public UMFirmaService(IUMFirmaDal firmaDal):base(firmaDal)
        {
            
        }

        public Firma GetByName(string name)
        {
            Firma result = null;
            try
            {
                if (name.Trim() != "")
                    result = _entityDal.Get(p => p.FirmaAd.Trim().ToLower().Equals(name.ToLower().Trim()));
                else
                    throw new Exception("Firma nesnesini getirmek için gerekli olan \n" +
                        "isim bilgisi eksi olduğu için işleminiz gerçekleştiremiyoruz.");
            }
            catch (Exception hata)
            {
                throw new Exception("Firma bilgisi getirilirken hata oluştu. Hata: \n"+hata.Message);
            }
            return result;
        }
    }
}
