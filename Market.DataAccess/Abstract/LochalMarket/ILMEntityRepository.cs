using Market.Entity.Abstract;
using Market.Entity.Concrete;
using System.Collections.Generic;

namespace Market.DataAccess.Abstract.LochalMarket
{
    public interface ILMEntityRepository<TEntity>:IEntityRepository<TEntity>
        where TEntity : EntityBase,IEntity,new()
    {
        void Add(List<TEntity> entities);
    }
}
