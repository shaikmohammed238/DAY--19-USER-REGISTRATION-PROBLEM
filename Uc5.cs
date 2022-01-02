using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    //Uc5 As a User need to follow pre-defined Password rules.Rule1– minimum 8 Characters - -------{NOTE – All rules must be passed}
    class Uc5
    {
      public static string REGEX_VALIDPASSWORD = "[a-z A-Z]{8,}";
       public bool ValidatePassWord(string Password)
       {
         return Regex.IsMatch(Password, REGEX_VALIDPASSWORD);
       }
    }
}
