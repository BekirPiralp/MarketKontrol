using Market.Entity.Concrete;
using System;

namespace Market.DataAccess.Abstract.UzakMarket
{
    public interface IUMFisDal :IFisDal,IUMEntityRepository<Fis>
    {
        
    }
}
