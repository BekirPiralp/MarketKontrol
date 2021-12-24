using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMDefoValidator :AbstractValidator<Defo>
    {
        public UMDefoValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Urun).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty(); boş olabilir veri tabnı oto atayabilir
            RuleFor(p => p.Adet).GreaterThan(0);
            RuleFor(p => p.Aciklama).NotEmpty();
        }

    }
}
