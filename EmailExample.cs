using System;
using System.Text.RegularExpressions;
namespace ValidateEmail
{
    public class EmailExample
    {
        private static string EMAIL_REGEX = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";

        public bool Validate(string regex)
        {
            bool matcher = Regex.IsMatch(regex, EMAIL_REGEX);
            return matcher;
        }
    }
}
