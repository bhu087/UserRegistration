using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        const string LAST_NAME_REGEX = FIRST_NAME_REGEX;
        const string EMAIL_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName,FIRST_NAME_REGEX);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LAST_NAME_REGEX);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
