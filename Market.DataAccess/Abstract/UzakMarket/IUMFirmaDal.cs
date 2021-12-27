using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    public interface IUMFirmaDal : IFirmaDal, IUMEntityRepository<Firma>
    {
    }
}
