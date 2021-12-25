using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMPersonelSilvalidator :AbstractValidator<PersonelSil>
    {
        public UMPersonelSilvalidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Aciklama).NotEmpty();
            RuleFor(p => p.TarihSaat).NotEmpty();
        }
    }
}
