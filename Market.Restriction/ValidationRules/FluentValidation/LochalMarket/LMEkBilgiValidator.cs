using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMEkBilgiValidator : AbstractValidator<EkBilgi>
    {
        public LMEkBilgiValidator()
        {
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Aciklama).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty(); // Veri tabanı tarafından oto atanıyor
        }
    }
}