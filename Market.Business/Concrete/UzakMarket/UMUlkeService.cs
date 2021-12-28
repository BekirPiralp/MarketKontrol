using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMUlkeService : UMBusinessRepositoryBaseService<Ulke, IUMUlkeDal, UMUlkeValidator>, IUMUlkeService
    {
        public UMUlkeService(IUMUlkeDal ulkeDal):base(ulkeDal)
        {

        }
    }
}
