using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class DataValidation
    {
        //Regex expression according to the conditions
        static string name_regex = "^[A-Z]{1}[a-zA-Z]{2,}$";
        static string eMail_regex = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
        static string mobileNumber_regex = "^[\\d]{2}\\s[\\d]{10}$";
        static string password_regex = "^(?=.*?[A-Z]{1})(?=.*?[0-9])(?=.*?[@.,;$%^&#{}+_]{1}).{8,}$";
        //parameters that are to be validated 
        public string firstName;
        public string lastName;
        public string email;
        public string mobileNo;
        public string password;

        /// <summary>
        /// Validates the First name and last name of the User
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Validates the Mobile Number
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns></returns>
        public string mobileNumberValidation(string mobileNumber)
        {
            Regex re = new Regex(mobileNumber_regex);
            try
            {
                if (re.IsMatch(mobileNumber))
                    return "Valid Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.customExceptionType.INVALID_MOBILE_NUMBER, "INVALID ENTRY");
            }

        }
        /// <summary>
        /// Validates the email Address
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public string emailValidation(string email)
        {
            Regex re = new Regex(eMail_regex);
            try
            {
                if (re.IsMatch(email))
                    return "Valid Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.customExceptionType.INVALID_EMAIL_ID, "INVALID ENTRY");
            }
        }
        /// <summary>
        /// validates the password
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public string passwordValidation(string password)
        {
            Regex re = new Regex(password_regex);
            try
            {
                if (re.IsMatch(password))
                    return "Valid Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.customExceptionType.INVALID_PASSWORD, "INVALID ENTRY");
            }
        }
    }
}
