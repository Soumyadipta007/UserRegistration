using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegexClass
    {
        public static string FIRSTNAMEREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LASTNAMEREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAILREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string MOBILENUMBERREGEX = "^[9]{1}[1]{1}[ ]{1}[6-9]{1}[0-9]{9}$";
        public static string PASSWORDREGEX = "(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[@$!%*#?&]).{8,}$";
        public static string PASSWORDREGEX2 = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";
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
        public bool validateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILENUMBERREGEX); ;
        }
        public bool validatePassword(string password)
        {
            bool valid1= Regex.IsMatch(password, PASSWORDREGEX); 
            bool valid2 = Regex.IsMatch(password, PASSWORDREGEX2);
            return valid1 && valid2;
        }
        public Func<string, bool> isValidFirstName = fName => Regex.IsMatch(fName, FIRSTNAMEREGEX);
        public Func<string, bool> isValidLastName = lName => Regex.IsMatch(lName, LASTNAMEREGEX);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EMAILREGEX);
        public Func<string, bool> isValidMobileNumber = mobNumber => Regex.IsMatch(mobNumber, MOBILENUMBERREGEX);
        public Func<string, bool> isValidPassword = password => Regex.IsMatch(password, PASSWORDREGEX) && Regex.IsMatch(password, PASSWORDREGEX2);
    }
}
