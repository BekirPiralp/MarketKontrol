using Market.Entity.Abstract;
using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract.UzakMarket
{
    public interface IUMEntityRepository<TEntity>:IEntityRepository<TEntity>
        where TEntity : EntityBase,IEntity,new()
    {
    }
}
