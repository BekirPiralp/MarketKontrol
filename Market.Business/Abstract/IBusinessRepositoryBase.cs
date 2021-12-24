using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Abstract
{
    public interface IBusinessRepositoryBase<TEntity> where TEntity: class,IEntity,new()
    {
        /*Temel olarak bütün sınıflarda gerekli olan methodlar...*/
        List<TEntity> GetAll();
        TEntity GetById(int Id);
        void Delete(TEntity entity);
        void DeleteById(int Id);
        void Update(TEntity entity);
        void Add(TEntity entity);
        void AddByList(List<TEntity> entities);
    }
}
