using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    interface IUMFirmaDal : IFirmaDal, IUMEntityRepository<Firma>
    {
    }
}
