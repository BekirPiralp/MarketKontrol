using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.UzakMarket
{
    public class UMFotografValidator : UMEntityValidatorBase<Fotograf>
    {
        public UMFotografValidator()
        {
            //RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Foto).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty(); veri tabanı oto atayacak
        }
    }
}
