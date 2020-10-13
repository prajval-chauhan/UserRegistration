using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserValidationCustomException : Exception
    {
        public enum customExceptionType
        {
            INVALID_FIRST_NAME, INVALID_LAST_NAME, INVALID_MOBILE_NUMBER, INVALID_EMAIL_ID, INVALID_PASSWORD 
        }
        public customExceptionType type;

        public UserValidationCustomException(customExceptionType type, string MESSAGE) : base(MESSAGE)
        {
            this.type = type;
        }
    }
}
