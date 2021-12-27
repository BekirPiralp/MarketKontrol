using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    public interface IUMCalisanDal : ICalisanDal, IUMEntityRepository<Calisan>
    {
    }
}
