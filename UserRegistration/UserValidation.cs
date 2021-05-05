using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserValidation
    {
        const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName,FIRST_NAME_REGEX);
        }
    }
}
