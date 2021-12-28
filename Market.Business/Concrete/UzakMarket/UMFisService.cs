﻿using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMFisService : UMBusinessRepositoryBaseService<Fis, IUMFisDal, UMFisValidator>, IUMFisService
    {
        public UMFisService(IUMFisDal fisDal):base(fisDal)
        {

        }
    }
}
