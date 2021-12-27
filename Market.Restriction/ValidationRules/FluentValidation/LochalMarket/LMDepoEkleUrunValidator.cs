using FluentValidation;
using Market.Entity.Concrete;

namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMDepoEkleUrunValidator: LMEntityValidatorBase<DepoEkleUrun>
    {
        public LMDepoEkleUrunValidator()
        {
            RuleFor(p => p.Urun).NotEmpty();
            RuleFor(p => p.Adet).GreaterThan(0);//sıfırdan büyük olmalı
        }
    }
}
