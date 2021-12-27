using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMPersonelAdresValidator : UMEntityValidatorBase<PersonelAdres>
    {
        public UMPersonelAdresValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Ulke).NotEmpty();
            RuleFor(p => p.Il).NotEmpty();
            RuleFor(p => p.Ilce).NotEmpty();
            RuleFor(p => p.Tarif).NotEmpty();
        }
    }
}
