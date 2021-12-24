using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMFisValidator: AbstractValidator<Fis>
    {
        public LMFisValidator()
        {
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Kod).NotEmpty();
            //RuleFor(p => p.Id).NotEmpty();// Uzak serverdan alacak buyüzden burada gerekli değil
            RuleFor(p => p.ToplamFiyat).GreaterThan(0);
            RuleFor(p => p.TarihSaat).NotEmpty(); // burdaki serverdan da ala bilir
        }
    }
}
