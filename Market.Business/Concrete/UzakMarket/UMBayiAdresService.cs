using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMBayiAdresService : UMBusinessRepositoryBaseService<BayiAdres, IUMBayiAdresDal, UMBayiAdresValidator>, IUMBayiAdresService
    {
        public UMBayiAdresService(IUMBayiAdresDal bayiAdresDal) : base(bayiAdresDal)
        {
            
        }

        public BayiAdres GetByBayi (Bayi bayi)
        {
            BayiAdres result = null;
            try
            {
                if (bayi != null && bayi.Id > 0 && bayi.Firma > 0)
                {
                    result = _entityDal.Get(p => p.Bayi == bayi.Id && p.Firma == bayi.Firma);
                }
                else
                    throw new Exception("Bayiyi getirmek için gerekli olan bilgiler tam gelmediği için\n" +
                        "işleminizi gerçekleştiremiyoruz.");
            }
            catch (Exception hata)
            {
                throw new Exception("Bayinin adres verisi getirilirken hata oluştu. Hata\n"+hata.Message);
            }
            return result;
        }
    }
}
