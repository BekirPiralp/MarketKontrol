using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMIlceValidator : UMEntityValidatorBase<Ilce>
    {
        public UMIlceValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Ulke).NotEmpty();
            RuleFor(p => p.Il).NotEmpty();
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
        }
    }
}
