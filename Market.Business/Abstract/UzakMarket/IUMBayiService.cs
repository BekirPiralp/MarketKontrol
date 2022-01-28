using Market.Entity.Concrete;
using System.Collections.Generic;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMBayiService : IBayiService,IUMBusinessRepositoryBaseService<Bayi>
    {
        List<Bayi> GetAllByFirma(Firma firma);
    }
}
