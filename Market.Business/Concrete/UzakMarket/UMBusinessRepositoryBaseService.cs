using FluentValidation;
using Market.Business.Abstract;
using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Abstract;
using Market.Entity.Concrete;
using Market.Restriction.Utilities;
using Market.Restriction.ValidationRules.FluentValidation;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMBusinessRepositoryBaseService<TEntity,IUMEntityDal,UMEntityValidator> : IUMBusinessRepositoryBaseService<TEntity>,IBusinessRepositoryBaseService<TEntity>
        where TEntity: EntityBase,IEntity,new()
        where IUMEntityDal:class,IUMEntityRepository<TEntity>
        where UMEntityValidator:UMEntityValidatorBase<TEntity>,IValidator,new()
    {
        private IUMEntityDal _entityDal;
        public UMBusinessRepositoryBaseService(IUMEntityDal entityDal)
        {
            _entityDal = entityDal;
        }

        public void Add(TEntity entity)
        {
            ValidationTool.Validate<UMEntityValidator>(entity);
            _entityDal.Add(entity);
        }

        public void AddByList(List<TEntity> entities)
        {
            ValidationTool.Validate<UMEntityValidator>(entities);

            for (int i = 0; i < entities.Count; i++)
            {
                _entityDal.Add(entities[i]);
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                Validators.EntityEmptyKontrol<TEntity, UMEntityValidator>
                (entity, Messages.bosNesne);
                _entityDal.Delete(entity);
            }
            catch
            {
                throw new Exception(Messages.silmeHata);
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                _entityDal.Delete(GetById(id));
            }
            catch
            {
                throw new Exception(Messages.silmeHata);
            }
        }

        public List<TEntity> GetAll() // lochal deki bayiler...
        {
            return Validators.EntityEmptyKontrol<TEntity, UMEntityValidator>
                (_entityDal.GetAll(), Messages.sistemdeBulunamadi);
        }

        public TEntity GetById(int Id)
        {
            TEntity result = _entityDal.Get(p => p.Id == Id);
            return Validators.EntityEmptyKontrol<TEntity, UMEntityValidator>
                   (result, Messages.nesneYok);
        }

        public void Update(TEntity entity)
        {
            try
            {
                Validators.EntityEmptyKontrol<TEntity, UMEntityValidator>
                        (entity, Messages.bosNesne);
                _entityDal.Update(entity);
            }
            catch
            {

                throw new Exception(Messages.guncellemeHata);
            }
        }
    }
}
