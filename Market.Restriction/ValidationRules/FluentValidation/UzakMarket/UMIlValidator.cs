using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMIlValidator : UMEntityValidatorBase<Il>
    {
        public UMIlValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Ulke).NotEmpty();
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
        }
    }
}
