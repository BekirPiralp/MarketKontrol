using Market.Entity.Concrete;
using System.Collections.Generic;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMSatisService : ISatisService, IUMBusinessRepositoryBaseService<Satis>
    {
        List<Satis> GetAllByFisList(List<Fis> fisler);
    }
}
