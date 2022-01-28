using Market.Entity.Concrete;
using System.Collections.Generic;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMPersonelService : IPersonelService,IUMBusinessRepositoryBaseService<Personel>
    {
        List<Personel> GetAllbyFirma(Firma firma);
    }
}
