using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMUrunValidator: LMEntityValidatorBase<Urun>
    {
        public LMUrunValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();//uzak serverdan gelecek
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Marka).NotEmpty();
            RuleFor(p => p.UretimYeri).NotEmpty();
            RuleFor(p => p.Indirim).Must(Filters.Indirim).WithMessage(Messages.Indirim);
            RuleFor(p => p.Fiyat).GreaterThan(0);
            RuleFor(p => p.Barkod).NotEmpty();
        }
    }
}
