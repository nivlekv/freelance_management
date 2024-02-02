using System.Text.RegularExpressions;

namespace FreelancersLib
{
    public static class StringUtil
    {
        public static bool IsNotEmpty(this string str) 
        {
            return !(str == null || str == "");
        }

        public static bool IsContains(this string str, string value)
        {
            return str.Contains(value, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsEmail(this string str)
        {
            return Regex.IsMatch(str, @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z");
        }
    }
}
