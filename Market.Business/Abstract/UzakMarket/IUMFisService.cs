using Market.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMFisService : IFisService,IUMBusinessRepositoryBaseService<Fis>
    {
        List<Fis> GetAllByMonth(Firma firma,Bayi bayi);
    }
}
