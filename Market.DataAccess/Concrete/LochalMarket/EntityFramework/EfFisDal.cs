﻿using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;

namespace Market.DataAccess.Concrete.LochalMarket.EntityFramework
{
    public class EfFisDal : EfEntityRepositoryBase<Fis,LochalMarketContext>,ILMFisDal
    {
    }
}
