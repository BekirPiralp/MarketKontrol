using FluentValidation;
using Market.Entity.Concrete;
using System;

namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMPersonelValidator :AbstractValidator<Personel>
    {
        public LMPersonelValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Tc).Must(Filters.Tc).WithMessage(Filters.messageTc);
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Soyad).NotEmpty();
            RuleFor(p => p.Cinsiyet).Must(Filters.Cinsiyet).WithMessage(Filters.messageCinsiyet);
            RuleFor(p => p.Firma).NotEmpty(); // Uzak veri tabanında bu firmaya ait olanlar çekilecek
        }
    }
}
