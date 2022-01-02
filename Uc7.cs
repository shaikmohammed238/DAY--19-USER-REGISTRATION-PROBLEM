using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
   public class Uc7
   {
     public static string REGEX_VALIDPASSWORD = "^[A-Z][0-9][A-Za-z0-9]{6}";
      public bool ValidatePassWord(string Password)
      {
        return Regex.IsMatch(Password, REGEX_VALIDPASSWORD);
      }
   }
}
