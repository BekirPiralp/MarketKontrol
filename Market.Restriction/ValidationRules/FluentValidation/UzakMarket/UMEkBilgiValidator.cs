using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMEkBilgiValidator : UMEntityValidatorBase<EkBilgi>
    {
        public UMEkBilgiValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty();//Veritabanı oto ataya bilir
            RuleFor(p => p.Aciklama).NotEmpty();
        }
    }
}
