using FluentValidation;
using Market.Entity.Abstract;
using Market.Restriction.Utilities;
using System;
using System.Collections.Generic;


namespace Market.Restriction.ValidationRules.FluentValidation
{
    public static class Validators
    {
        public static TEntity EntityEmptyKontrol<TEntity, EntityValidator>(TEntity entity, String Message = "")
            where TEntity : class, IEntity, new()
            where EntityValidator : AbstractValidator<TEntity>, new()
        {
            if (entity == null)
                throw new Exception(Message);
            else
            {
                ValidationTool.Validate<EntityValidator>(entity);
                return entity;
            }
        }
        public static List<TEntity> EntityEmptyKontrol<TEntity, EntityValidator>(List<TEntity> entities, String Message = "")
            where TEntity : class, IEntity, new()
            where EntityValidator : AbstractValidator<TEntity>, new()
        {

            if (entities.Count == 0)
                throw new Exception(Message);
            else
            {
                ValidationTool.Validate<EntityValidator>(entities);
                return entities;
            }

        }
    }
}
