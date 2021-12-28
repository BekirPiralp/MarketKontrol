using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMFirmaService:UMBusinessRepositoryBaseService<Firma,IUMFirmaDal,UMFirmaValidator>,IUMFirmaService
    {
        public UMFirmaService(IUMFirmaDal firmaDal):base(firmaDal)
        {

        }
    }
}
