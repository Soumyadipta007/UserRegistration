using System;
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
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            if (regexClass.validateFirstName(name))
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("InValid First Name");
            
        }
    }
}
