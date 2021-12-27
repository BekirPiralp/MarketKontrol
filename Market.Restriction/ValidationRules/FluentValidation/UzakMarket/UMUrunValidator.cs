using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMUrunValidator : UMEntityValidatorBase<Urun>
    {
        public UMUrunValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Barkod).NotEmpty();
            RuleFor(p => p.Marka).NotEmpty();
            RuleFor(p => p.UretimYeri).NotEmpty();
            RuleFor(p => p.Aciklama).NotEmpty();
            RuleFor(p => p.Adet).GreaterThanOrEqualTo(0);
            RuleFor(p => p.Resim).NotEmpty();
            RuleFor(p => p.Indirim).Must(Filters.Indirim).WithMessage(Messages.Indirim);
            RuleFor(p => p.Fiyat).GreaterThan(0);
        }
    }
}
