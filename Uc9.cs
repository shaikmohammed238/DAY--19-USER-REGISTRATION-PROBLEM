using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    //Uc9 Should clear all email samples provided separately {check all emails}
    public class Uc9
    {
      public static string REGEX_VALIDEMAILS = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
       public bool ValidateEmails(string Emails)
       {
         return Regex.IsMatch(Emails, REGEX_VALIDEMAILS);
       }
    }
}
