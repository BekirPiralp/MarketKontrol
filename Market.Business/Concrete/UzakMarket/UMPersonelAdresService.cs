using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMPersonelAdresService : UMBusinessRepositoryBaseService<PersonelAdres, IUMPersonelAdresDal, UMPersonelAdresValidator>, IUMPersonelAdresService
    {
        public UMPersonelAdresService(IUMPersonelAdresDal personelAdresDal):base(personelAdresDal)
        {

        }
    }
}
