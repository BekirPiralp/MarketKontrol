using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMYoneticiValidator : UMEntityValidatorBase<Yonetici>
    {
        public UMYoneticiValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
        }
    }
}
