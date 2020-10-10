using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegister
    {
        private string message;
        RegexClass regexClass = new RegexClass();
        public UserRegister()
        {
        }
        public UserRegister(string message)
        {
            this.message = message;
        }
        public string checkFirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string checkLastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string checkEmail()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string checkMobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string checkPassword()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string checkmultipleEmails(string email1,string email2)
        {
            bool ans1 = regexClass.validateEmail(email1);
            bool ans2 = regexClass.validateEmail(email2);
            if(ans1 && ans2)
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public void checkFirstName(string firstName)
        {
            if (regexClass.validateFirstName(firstName))
                Console.WriteLine("Valid First Name");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "First Name is Invalid");
        }
        public void checkLastName(string lastName)
        {
            if (regexClass.validateLastName(lastName))
                Console.WriteLine("Valid Last Name");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Last Name is Invalid");
        }
        public void checkEmail(string email)
        {
            if (regexClass.validateEmail(email))
                Console.WriteLine("Valid Email");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Email is Invalid");
        }
        public void checkMobileNumber(string mobileNumber)
        {
            if (regexClass.validateMobileNumber(mobileNumber))
                Console.WriteLine("Valid Mobile Number");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILENUMBER, "Mobile number is Invalid");
        }
        public void checkPassword(string password)
        {
            if (regexClass.validatePassword(password))
                Console.WriteLine("Valid Password");
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
        }
    }
}
