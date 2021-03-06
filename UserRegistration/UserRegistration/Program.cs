﻿using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            if (regexClass.validateFirstName(firstName))
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("InValid First Name");
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            if (regexClass.validateLastName(lastName))
                Console.WriteLine("Valid Last Name");
            else
                Console.WriteLine("InValid Last Name");
            Console.WriteLine("Enter the Email");
            string email = Console.ReadLine();
            if (regexClass.validateEmail(email))
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("InValid Email");
            Console.WriteLine("Enter Mobile Number");
            string mobileNumber = Console.ReadLine();
            if (regexClass.validateMobileNumber(mobileNumber))
                Console.WriteLine("Valid Mobile Number");
            else
                Console.WriteLine("InValid Mobile Number");
            Console.WriteLine("Enter Password");
            string pasword = Console.ReadLine();
            if (regexClass.validatePassword(pasword))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
