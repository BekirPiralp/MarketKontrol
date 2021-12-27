using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMYoneticiService : UMBusinessRepositoryBaseService<Yonetici,IUMYoneticiDal,UMYoneticiValidator>,IUMYoneticiService
    {
        public UMYoneticiService(IUMYoneticiDal yoneticiDal):base(yoneticiDal)
        {

        }
    }
}
