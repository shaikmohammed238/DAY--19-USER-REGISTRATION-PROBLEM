using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    //UC1 First name starts with Cap and has minimum 3 characters
    public class Uc1
   {
     public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Z a-z]{2,}$";
      public bool ValidateName(string FIRSTNAME )
      {
        return Regex.IsMatch(FIRSTNAME, REGEX_FIRSTNAME);
      }
   }
}
