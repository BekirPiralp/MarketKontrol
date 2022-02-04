using System;


namespace Market.Restriction.ValidationRules.FluentValidation
{
    public static class Filters
    {
        private const int _uzunlukTc = 11;

        public static bool Cinsiyet(string arg)
        {

            if (arg.Trim().ToLower().Equals("Erkek".ToLower()) || arg.Trim().ToLower().Equals("Kadın".ToLower()))
                return true;
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
        public static bool Indirim(double arg)
        {
            return arg >= 0 && arg <= 100 ? true : false;
        }
    }
}
