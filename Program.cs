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
    }
}
