using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMIadeValidator :AbstractValidator<Iade>
    {
        public UMIadeValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Fis).NotEmpty();
            RuleFor(p => p.Satis).NotEmpty();
            RuleFor(p => p.Aciklama).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty();// veri tabanı oto atayacak
        }
    }
}
