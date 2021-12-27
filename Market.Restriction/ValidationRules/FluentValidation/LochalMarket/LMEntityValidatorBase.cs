using FluentValidation;
using Market.Entity.Abstract;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMEntityValidatorBase<TEntity>:AbstractValidator<TEntity>
        where TEntity:EntityBase,IEntity,new()
    {
    }
}
