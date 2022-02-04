using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMPersonelValidator : UMEntityValidatorBase<Personel>
    {
        public UMPersonelValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Soyad).NotEmpty();
            RuleFor(p => p.Tc).Must(Filters.Tc).WithMessage(Messages.Tc);
            RuleFor(p => p.Cinsiyet).Must(Filters.Cinsiyet).WithMessage(Messages.Cinsiyet);
        }
    }
}
