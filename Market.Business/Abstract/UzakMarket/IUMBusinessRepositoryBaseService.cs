using Market.Entity.Abstract;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Abstract.UzakMarket
{
    public interface IUMBusinessRepositoryBaseService<TEntity> : IBusinessRepositoryBaseService<TEntity>
        where TEntity:EntityBase,IEntity,new()
    {
    }
}
