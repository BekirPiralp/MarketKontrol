using FluentValidation;
using Market.Entity.Concrete;
using System;

namespace Market.Restriction.ValidationRules.FluentValidation.LochalMarket
{
    public class LMPersonelValidator :AbstractValidator<Personel>
    {
        private const int _uzunlukTc = 11;
        public LMPersonelValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Tc).Must(Sayi).WithMessage("TC Kimlik numarası 11 hane ve sadece sayı olmalıdır.");
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Soyad).NotEmpty();
            RuleFor(p => p.Cinsiyet).Must(Cinsiyet).WithMessage("Cinsiyeti Belirtiniz");
            RuleFor(p => p.Firma).NotEmpty(); // Uzak veri tabanında bu firmaya ait olanlar çekilecek
        }

        private bool Cinsiyet(char arg)
        {

            string kontrol = "KkEe";
            foreach (var k in kontrol)
            {
                if (k == arg)
                    return true;
            }
            return false;
        }

        private static bool Sayi(string arg)
        {
            string kontrol = "1234567890";
            bool temp = false;
            arg = arg.Trim();
            if (String.IsNullOrEmpty(arg) || arg.Length != _uzunlukTc)
                return false;
            foreach (var i in arg)
            {
                foreach( var s in kontrol)
                {
                    if (i == s)
                    {
                        temp = true;
                        break;
                    }
                }
                if (!temp)
                    return false;
            }
            return true;
        }
    }
}
