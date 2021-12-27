using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    interface IUMFisDal:IFisDal,IUMEntityRepository<Fis>
    {
    }
}
