using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMIlService : UMBusinessRepositoryBaseService<Il, IUMIlDal, UMIlValidator>, IUMIlService
    {
        public UMIlService(IUMIlDal ilDal):base(ilDal)
        {

        }

        public List<Il> GetByUlkeId(int ulkeId)
        {
            List<Il> result=null;
            try
            {
                result = _entityDal.GetAll(p=>p.Ulke==ulkeId);
            }
            catch
            {
                throw new Exception("İl getirmede hata ile karşılaşıldı.");
            }
            return result;
        }
    }
}
