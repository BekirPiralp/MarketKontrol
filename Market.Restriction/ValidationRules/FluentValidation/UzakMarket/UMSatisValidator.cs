using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMSatisValidator : UMEntityValidatorBase<Satis>
    {
        public UMSatisValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Fis).NotEmpty();
            RuleFor(p => p.Urun).NotEmpty();
            RuleFor(p => p.Adet).GreaterThan(0);
        }
    }
}
