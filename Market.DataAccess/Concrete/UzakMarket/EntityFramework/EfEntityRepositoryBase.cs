using Market.DataAccess.Abstract;
using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Concrete.UzakMarket.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                TEntity result;
                result = context.Set<TEntity>().Where(filter).FirstOrDefault(); // ilk olanı veya varsayılan veri gelecek
                return result;
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext()) {
                return filter == null ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList(); 
            }
        }

        public async void Update(TEntity entity)
        {
            using ( TContext context = new TContext()) {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

         
    }
}
