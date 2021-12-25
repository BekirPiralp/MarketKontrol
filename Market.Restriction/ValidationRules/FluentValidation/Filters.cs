using System;


namespace Market.Restriction.ValidationRules.FluentValidation
{
    public static class Filters
    {
        private const int _uzunlukTc = 11;
        public const string messageTc = "TC Kimlik numarası 11 hane ve sadece sayı olmalıdır.";
        public const string messageCinsiyet = "Cinsiyeti Belirtiniz";
        public const string messageIndirim = "İndidrim %0 - %100 arası olabilir.";

        public static bool Cinsiyet(char arg)
        {

            string kontrol = "KkEe";
            foreach (var k in kontrol)
            {
                if (k == arg)
                    return true;
            }
            return false;
        }
        public static bool Tc(string arg)
        {
            string kontrol = "1234567890";
            bool temp = false;
            arg = arg.Trim();
            if (String.IsNullOrEmpty(arg) || arg.Length != _uzunlukTc)
                return false;
            foreach (var i in arg)
            {
                foreach (var s in kontrol)
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
        public static bool Indirim(float arg)
        {
            return arg >= 0 && arg <= 100 ? true : false;
        }
    }
}
