using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class RegexClass
    {
        public static string NAMEREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool validateFirstName(string name)
        {
            return Regex.IsMatch(name, NAMEREGEX);
        }
    }
}
