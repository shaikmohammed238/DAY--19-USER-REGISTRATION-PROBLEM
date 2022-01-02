using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    //Uc6 RULE 2 : Should Have Atleast One Upper Case  ----------- { NOTE – All rules must be passed}
    class Uc6
    {
      public static string REGEX_VALIDPASSWORD = "^[A-Z][A-Za-z0-9]{7}";
       public bool ValidatePassWord(string Password)
       {
         return Regex.IsMatch(Password, REGEX_VALIDPASSWORD);
       }
    }
}
