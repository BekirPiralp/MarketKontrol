using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMBayiValidator : UMEntityValidatorBase<Bayi>
    {
        public UMBayiValidator()
        {
            //RuleFor(p => p.Id).NotEmpty(); // Veri tabanı atayacak zaten ve yüklemede yapılan kontrolde hataya sebep olur
            RuleFor(p => p.BayiAd).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
        }
    }
}
