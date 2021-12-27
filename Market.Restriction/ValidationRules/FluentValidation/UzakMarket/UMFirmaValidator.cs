using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMFirmaValidator : UMEntityValidatorBase<Firma>
    {
        public UMFirmaValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.FirmaAd).NotEmpty();
        }
    }
}
