using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMMudurValidator : UMEntityValidatorBase<Mudur>
    {
        public UMMudurValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();//Seerverdan alacak
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
        }
    }
}
