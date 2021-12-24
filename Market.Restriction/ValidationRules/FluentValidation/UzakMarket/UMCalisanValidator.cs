using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMCalisanValidator:AbstractValidator<Calisan>
    {
        public UMCalisanValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Gorev).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
        }
    }
}
