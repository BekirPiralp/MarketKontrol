﻿using Market.DataAccess.Abstract;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Concrete.UzakMarket.EntityFramework
{
    public class EfCalisanDal : EfEntityRepositoryBase<Calisan,UzakMarketContext>,ICalisanDal 
    {
    }
}