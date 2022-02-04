using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMUlkeValidator : UMEntityValidatorBase<Ulke>
    {
        public UMUlkeValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
        }
    }
}
