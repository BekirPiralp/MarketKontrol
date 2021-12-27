using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMPersonelSifreValidator: LMEntityValidatorBase<PersonelSifre>
    {
        public LMPersonelSifreValidator()
        {
            /*Lochal de şifre değiştirme olmayacak*/
            //RuleFor(p => p.Sifre).NotEmpty();//uzak veri trabanından gelecek
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Sifre).NotEmpty();
        }
    }
}
