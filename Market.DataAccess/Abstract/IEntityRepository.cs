using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity:class, IEntity, new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        void Update(TEntity entity);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
