using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMFisValidator :AbstractValidator<Fis>
    {
        public UMFisValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Kod).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty();//Veri tabanı oto ataması var
            RuleFor(p => p.ToplamFiyat).GreaterThan(0);
        }
    }
}
