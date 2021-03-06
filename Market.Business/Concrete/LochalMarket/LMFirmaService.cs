using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMFirmaService :LMBusinessRepositoryBaseService<Firma,ILMFirmaDal,LMFirmaValidator> ,ILMFirmaService
    {
        public LMFirmaService(ILMFirmaDal firmaDal):base(firmaDal)
        {

        }
    }
}
