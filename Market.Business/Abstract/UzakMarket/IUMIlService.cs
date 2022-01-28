using Market.Entity.Concrete;
using System.Collections.Generic;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMIlService : IIlService,IUMBusinessRepositoryBaseService<Il>
    {
        List<Il> GetByUlkeId(int ulkeId);
    }
}
