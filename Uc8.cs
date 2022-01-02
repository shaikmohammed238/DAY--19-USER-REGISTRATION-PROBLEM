using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    //Uc8 Rule4 – Has exactly 1 Special Character--------- {NOTE – All rules must be passed}
    class Uc8
    {
      public static string REGEX_VALIDPASSWORD = "^[A-Z][0-9][!*@#$%^&+=][A-Za-z0-9]{5}";
       public bool ValidatePassWord(string Password)
       {
         return Regex.IsMatch(Password, REGEX_VALIDPASSWORD);
       }
    }
}
