using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    //uc 4 Mobile Format -E.g. 91 9919819801 - Country code follow by space and 10 digit number
    class Uc4
    {
      public static string REGEX_MOBILENUMBER = @"[91] [6,7,8,9]{1}[0-9]{9}";
       public bool ValidateNumber(string Number)
       {
         return Regex.IsMatch(Number, REGEX_MOBILENUMBER);
       }
    }
}
