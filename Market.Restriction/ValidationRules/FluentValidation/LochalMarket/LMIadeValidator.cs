using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMIadeValidator : LMEntityValidatorBase<Iade>
    {
        public LMIadeValidator()
        {
            //RuleFor(p => p.Id).NotEmpty()// aslını uzak serverda alacak
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Fis).NotEmpty();
            RuleFor(p => p.Satis).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty(); // serverdan ala bilir
            RuleFor(p => p.Aciklama).NotEmpty();
        }
    }
}
