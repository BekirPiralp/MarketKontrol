using Market.Entity.Concrete;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMFirmaService : IFirmaService,IUMBusinessRepositoryBaseService<Firma>
    {
        Firma GetByName(string name);
    }
}
