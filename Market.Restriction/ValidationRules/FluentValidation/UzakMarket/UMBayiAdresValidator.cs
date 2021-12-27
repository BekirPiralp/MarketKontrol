using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMBayiAdresValidator: UMEntityValidatorBase<BayiAdres>
    {
        public UMBayiAdresValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(P => P.Ulke);
            RuleFor(p => p.Il).NotEmpty();
            RuleFor(p => p.Ilce).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Tarif).NotEmpty();
        }
    }
}
