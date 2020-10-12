using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class DataValidation
    {
        static string name_regex = "^[A-Z]{1}[a-zA-Z0-9]{2,}$";
        static string eMail_regex = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
        static string mobileNumber_regex = "^[\\d]{2}\\s[\\d]{10}$";
        static string password_regex = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[@.,;$%^&#{}+_]{1}).{8,}$";

        public string firstName;
        public string lastName;
        public string email;
        public string mobileNo;
        public string password;

        public bool NameCheck(string name)
        {
            Regex reg = new Regex(name_regex);
            if (reg.IsMatch(name))
            {
                Console.WriteLine("Valid\n");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                Console.ReadKey();
                Console.Clear();
                return false;
            }

        }
        public bool mobileNumberValidation(string mobileNumber)
        {
            Regex re = new Regex(mobileNumber_regex);
            if (re.IsMatch(mobileNumber))
            {
                Console.WriteLine("Valid\n");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }
        public bool emailValidation(string email)
        {
            Regex re = new Regex(eMail_regex);
            if (re.IsMatch(email))
            {
                Console.WriteLine("Valid\n");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }
        public bool passwordValidation(string password)
        {
            Regex re = new Regex(password_regex);
            if (re.IsMatch(password))
            {
                Console.WriteLine("Valid\n");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }
    }
}
