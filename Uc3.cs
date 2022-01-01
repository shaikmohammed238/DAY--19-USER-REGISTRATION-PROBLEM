using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    // Uc3-Email has 3 mandatory parts (abc,bl & co) and 2 optional(xyz & in) with precise @ and.positions
    class Uc3
    {
      public static string REGEX_EMAIL = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})*$";
       public bool ValidateEmail(string EMAIL)
       {
         return Regex.IsMatch(EMAIL, REGEX_EMAIL);
       }
    }
}
