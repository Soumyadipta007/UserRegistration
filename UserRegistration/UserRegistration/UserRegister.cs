using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegister
    {
        private string message;
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
    }
}
