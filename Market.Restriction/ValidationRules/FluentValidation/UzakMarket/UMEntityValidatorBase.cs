using FluentValidation;
using Market.Entity.Abstract;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMEntityValidatorBase<TEntity>:AbstractValidator<TEntity>
        where TEntity:EntityBase,IEntity,new()
    {
    }
}
