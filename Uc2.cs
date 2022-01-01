using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{ 
    //UC2  Last name starts with Cap and has minimum 3 characters
    class Uc2
    {
      public static string REGEX_LASTNAME = "^[A-Z]{1}[A-Z a-z]{2,}$";
        public bool ValidateName(string LASTNAME)
        {
          return Regex.IsMatch(LASTNAME, REGEX_LASTNAME);
        }
    }
}
