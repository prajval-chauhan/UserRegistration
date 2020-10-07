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
            mobileNumberValidation();
            passwordValidation();

            
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

        public static void mobileNumberValidation()
        {
            string mobileNumber = "^[\\d]{2}\\s[\\d]{10}$";
            Console.WriteLine("Enter the mobile number : ");
            string input = Console.ReadLine();

            Regex re = new Regex(mobileNumber);
            if (re.IsMatch(input))
                Console.WriteLine("Mobile Number is valid");
            else
                Console.WriteLine("Mobile Number is not valid");
        }

        public static void passwordValidation()
        {
            string password = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[@.,;$%^&#{}+_]{1}).{8,}$";
            Console.WriteLine("Enter the password : ");
            string input = Console.ReadLine();

            Regex re = new Regex(password);
            if (re.IsMatch(input))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is not valid");
        }
    }
}
