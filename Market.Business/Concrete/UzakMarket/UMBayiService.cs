using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMBayiService : UMBusinessRepositoryBaseService<Bayi, IUMBayiDal, UMBayiValidator>, IUMBayiService
    {
        public UMBayiService(IUMBayiDal bayiDal) : base(bayiDal)
        {

        }
    }
}
