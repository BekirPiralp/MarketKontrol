using FluentValidation;
using Market.Entity.Concrete;


namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMDefoValidator: LMEntityValidatorBase<Defo>
    {
        public LMDefoValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Bayi).NotEmpty();
            RuleFor(p => p.Firma).NotEmpty();
            RuleFor(p => p.Personel).NotEmpty();
            RuleFor(p => p.Urun).NotEmpty();
            //RuleFor(p => p.TarihSaat).NotEmpty();// null olabliri mi ? Veri tabnının ataması sağlana bilir
            RuleFor(p => p.Adet).LessThan(0);//Sıfırdan büyük olmalı
            RuleFor(p => p.Aciklama).NotEmpty();
        }
    }
}
