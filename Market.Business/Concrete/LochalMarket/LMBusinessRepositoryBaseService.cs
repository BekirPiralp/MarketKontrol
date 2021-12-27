using FluentValidation;
using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Abstract;
using Market.Entity.Concrete;
using Market.Restriction.Utilities;
using Market.Restriction.ValidationRules.FluentValidation;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMBusinessRepositoryBaseService<TEntity,ILMEntityDal,LMEntityValidator> : ILMBusinessRepositoryBaseService<TEntity> // imlement
        where TEntity:EntityBase,IEntity,new()
        where ILMEntityDal:class,ILMEntityRepository<TEntity>
        where LMEntityValidator:LMEntityValidatorBase<TEntity>,IValidator,new()
        
    {
        protected ILMEntityDal _entityDal;
        public LMBusinessRepositoryBaseService(ILMEntityDal entityDal)
        {
            _entityDal = entityDal;
        }

        public void Add(TEntity entity)
        {
            ValidationTool.Validate<LMEntityValidator>(entity);
            _entityDal.Add(entity);
        }

        public void AddByList(List<TEntity> entities)
        {
            ValidationTool.Validate<LMEntityValidator>(entities);
            _entityDal.Add(entities);            
        }

        public void Delete(TEntity entity)
        {
            try
            {
                Validators.EntityEmptyKontrol<TEntity, LMEntityValidator>
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
            return Validators.EntityEmptyKontrol<TEntity, LMEntityValidator>
                (_entityDal.GetAll(), Messages.sistemdeBulunamadi);
        }

        public TEntity GetById(int Id)
        {
            TEntity result = _entityDal.Get(p => p.Id == Id);
            return Validators.EntityEmptyKontrol <TEntity, LMEntityValidator >
                   (result, Messages.nesneYok);
        }

        public void Update(TEntity entity)
        {
            try
            {
                Validators.EntityEmptyKontrol<TEntity, LMEntityValidator>
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
