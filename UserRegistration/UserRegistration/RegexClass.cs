using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class RegexClass
    {
        public static string FIRSTNAMEREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LASTNAMEREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAILREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public bool validateFirstName(string name)
        {
            return Regex.IsMatch(name, FIRSTNAMEREGEX);
        }
        public bool validateLastName(string name)
        {
            return Regex.IsMatch(name, LASTNAMEREGEX);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAILREGEX); ;
        }
    }
}
