using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.LochalMarket
{
    public interface ILMFirmaDal : ILMEntityRepository<Firma>, IFirmaDal
    {
    }
}
