using System;

namespace DAY__19_USER_REGISTRATION_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //UC1 First name starts with Cap and has minimum 3 characters

                Uc1 P = new Uc1();
                Console.WriteLine("ENTER YOUR FIRST NAME :");
                var check = P.ValidateName(Console.ReadLine());
                Console.WriteLine(check);

                //UC2  Last name starts with Cap and has minimum 3 characters

                Uc2 uc2 = new Uc2();
                Console.WriteLine("ENTER YOUR LAST NAME :");
                var check1 = uc2.ValidateName(Console.ReadLine());
                Console.WriteLine(check1); 

                // Uc3-Email has 3 mandatory parts (abc,bl & co) and 2 optional(xyz & in) with precise @ and.positions  
                 
                Uc3 uc3 = new Uc3();
                Console.WriteLine("ENTER YOUR EMAIL :");
                var check2 = uc3.ValidateEmail(Console.ReadLine());
                Console.WriteLine(check2);  

                //uc 4 Mobile Format -E.g. 91 9919819801 - Country code follow by space and 10 digit number

                Uc4 uc4 = new Uc4();
                Console.WriteLine("ENTER YOUR MOBILE NUMBER :");
                var check3 = uc4.ValidateNumber(Console.ReadLine());
                Console.WriteLine(check3); 

                //Uc5 As a User need to follow pre-defined Password rules.Rule1– minimum 8 Characters - -------{NOTE – All rules must be passed}

                Uc5 uc5 = new Uc5();
                Console.WriteLine("ENTER MINIMUM 8 CHARACTERS");
                Console.WriteLine("NOTE: Rule1– minimum 8 Characters");
                var check4 = uc5.ValidatePassWord(Console.ReadLine());
                Console.WriteLine(check4);

                //Uc6 RULE 2 : Should Have Atleast One Upper Case  ----------- { NOTE – All rules must be passed}

                Uc6 uc6= new Uc6();
                Console.WriteLine("ENTER MINIMUM 8 CHARACTERS");
                Console.WriteLine("NOTE: Rule2– Should Have Atleast One Upper Case");
                var check5 = uc6.ValidatePassWord(Console.ReadLine());
                Console.WriteLine(check5);

                //Uc7 Should have at least 1numeric number in the password ------- {NOTE – All rules must be passed}

                Uc7 uc7= new Uc7();
                Console.WriteLine("ENTER MINIMUM 8 CHARACTERS");
                Console.WriteLine("NOTE: Rule3 -Should have at least 1numeric number in the password");
                var check6 = uc7.ValidatePassWord(Console.ReadLine());
                Console.WriteLine(check6);

                //Uc8 Rule4 – Has exactly 1 Special Character--------- {NOTE – All rules must be passed}

                Uc8 uc8= new Uc8();
                Console.WriteLine("ENTER MINIMUM 8 CHARACTERS");
                Console.WriteLine("NOTE: Rule4 – Has exactly 1 Special Character");
                var check7 = uc8.ValidatePassWord(Console.ReadLine());
                Console.WriteLine(check7);

                //Uc9 Should clear all email samples provided separately {check all emails}//

                Uc9 uc9= new Uc9();
                Console.WriteLine("ENTER CHECK ALL EMAILS ");
                var check8 = uc9.ValidateEmails(Console.ReadLine());
                Console.WriteLine(check8);
            }
        }
    }
}
