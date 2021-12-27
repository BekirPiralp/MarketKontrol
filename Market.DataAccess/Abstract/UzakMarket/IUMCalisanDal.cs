using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    interface IUMCalisanDal : ICalisanDal, IUMEntityRepository<Calisan>
    {
    }
}
