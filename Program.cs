using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the new user registration program");
            firstNameCheck();
            lastNameCheck();
            emailValidation();

            
        }
        static void firstNameCheck()
        {
            string name = "^[A-Z]{1}[a-zA-Z0-9]{2,15}$";
            Regex reg = new Regex(name);
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();
            if (reg.IsMatch(firstName))
                Console.WriteLine("Valid");
            else
                Console.WriteLine( "Invalid"); 

        }

        static void lastNameCheck()
        {
            string name = "^[A-Z]{1}[a-zA-Z0-9]{2,15}$";
            Regex reg = new Regex(name);
            Console.WriteLine("Enter your last Name: ");
            string lastName = Console.ReadLine();
            if (reg.IsMatch(lastName))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

        }

        public static void emailValidation()
        {
            string eMail = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Console.WriteLine("Enter the email ID you want to validate: ");
            string input = Console.ReadLine();

            Regex re = new Regex(eMail);
            if (re.IsMatch(input))
                Console.WriteLine("Email ID is valid");
            else
                Console.WriteLine("Email ID is not valid");
        }
    }
}
