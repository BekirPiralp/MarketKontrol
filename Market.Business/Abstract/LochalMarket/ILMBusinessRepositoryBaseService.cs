using Market.Entity.Abstract;
using Market.Entity.Concrete;

namespace Market.Business.Abstract.LochalMarket
{
    public interface ILMBusinessRepositoryBaseService<TEntity> : IBusinessRepositoryBaseService<TEntity>
        where TEntity : EntityBase, IEntity, new()
    {        
    }
}
