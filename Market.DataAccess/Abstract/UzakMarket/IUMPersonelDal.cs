using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    public interface IUMPersonelDal :IPersonelDal,IUMEntityRepository<Personel>
    {
    }
}
