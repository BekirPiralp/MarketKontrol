using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMSatisValidator : AbstractValidator<Satis>
    {
        public LMSatisValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();//Uzak serverda alacak
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Urun).NotEmpty();
            //RuleFor(p => p.Fis).NotEmpty();// Uzak servadkini alacak buradaki geçici
            RuleFor(p => p.Adet).GreaterThan(0);
        }
    }
}
