using Market.Entity.Concrete;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMBayiAdresService : IBayiAdresService,IUMBusinessRepositoryBaseService<BayiAdres>
    {
        BayiAdres GetByBayi(Bayi bayi);
    }
}
