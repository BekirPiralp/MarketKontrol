using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Abstract;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Market.DataAccess.Concrete.LochalMarket.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : ILMEntityRepository<TEntity>
        where TEntity : EntityBase, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        
        public void Add(List<TEntity> entities)
        {
            using (TContext context = new TContext())
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    context.Entry(entities[i]).State = EntityState.Added;
                    context.SaveChanges();
                }                
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().Where(filter).FirstOrDefault(); // ilk olanı veya varsayılan veri gelecek
                
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
