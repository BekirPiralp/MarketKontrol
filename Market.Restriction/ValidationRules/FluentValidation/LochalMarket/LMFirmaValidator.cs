using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMFirmaValidator:AbstractValidator<Firma>
    {
        public LMFirmaValidator()
        {
            RuleFor(p => p.Id).NotEmpty(); // Uzak veri tabanı tarafındaki id alınacak
            RuleFor(p => p.FirmaAd).NotEmpty();
        }
    }
}
