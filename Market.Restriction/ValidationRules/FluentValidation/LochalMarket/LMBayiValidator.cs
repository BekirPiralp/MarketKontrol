using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMBayiValidator: LMEntityValidatorBase<Bayi>
    {
        public LMBayiValidator()
        {
            RuleFor(p => p.BayiAd).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Id).NotEmpty(); // Ana sistemden gelecek
        }
    }
}
