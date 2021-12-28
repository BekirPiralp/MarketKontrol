using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMDefoService : UMBusinessRepositoryBaseService<Defo, IUMDefoDal, UMDefoValidator>, IUMDefoService
    {
        public UMDefoService(IUMDefoDal defoDal) : base(defoDal)
        {

        }
    }
}
