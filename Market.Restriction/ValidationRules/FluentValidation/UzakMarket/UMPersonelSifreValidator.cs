using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMPersonelSifreValidator :AbstractValidator<PersonelSifre>
    {
        public UMPersonelSifreValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Sifre).NotEmpty();
        }
    }
}
