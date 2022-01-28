using Market.Entity.Concrete;
using System.Collections.Generic;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMCalisanService : ICalisanService,IUMBusinessRepositoryBaseService<Calisan>
    {
        List<Calisan> GetAllByFirmaBayi(Firma firma, Bayi bayi);
        List<Calisan> GetAllByFirma(Firma firma);
    }
}
