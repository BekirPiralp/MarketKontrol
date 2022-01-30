using Market.Entity.Concrete;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMMudurService : IMudurService,IUMBusinessRepositoryBaseService<Mudur>
    {
        Mudur GetByBayi(int bayiId, int firmaId);
    }
}
