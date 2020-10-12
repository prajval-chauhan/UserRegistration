using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{

    class Program
    {
        static void Main(string[] args)
        {
            DataValidation call = new DataValidation();
            Console.WriteLine("***Welcome to the new user registration program***");
            do
            {
                Console.WriteLine("Enter the first name: ");
                call.firstName = Console.ReadLine();
            } while (call.NameCheck(call.firstName) == false);

            do
            {
                Console.WriteLine("Enter the Last name: ");
                call.lastName = Console.ReadLine();
            } while (call.NameCheck(call.lastName) == false);

            do
            {
                Console.WriteLine("Enter your mobile number: ");
                call.mobileNo = Console.ReadLine();
            } while (call.mobileNumberValidation(call.mobileNo) == false);

            do
            {
                Console.WriteLine("Enter the email address: ");
                call.email = Console.ReadLine();
            } while (call.emailValidation(call.email) == false);
        }
    }
}
