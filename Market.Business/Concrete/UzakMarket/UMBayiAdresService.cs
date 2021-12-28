using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMBayiAdresService : UMBusinessRepositoryBaseService<BayiAdres, IUMBayiAdresDal, UMBayiAdresValidator>, IUMBayiAdresService
    {
        public UMBayiAdresService(IUMBayiAdresDal bayiAdresDal) : base(bayiAdresDal)
        {

        }
    }
}
