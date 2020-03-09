namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This class contains code to validate user data and display
    /// </summary>
    public class RegexPatternMatch
    {
        /// <summary>
        /// This method take user data and check that it is according to pattern by using Regex.
        /// </summary>
        public static void CheckPattern()
        {
            Regex rname = new Regex("^[A-Za-z]{1,30}$");                         //// This Regex check the name pattern
            Regex rfull = new Regex("^[A-Za-z]{1,30} [A-Za-z]{1,30}$");          //// This Regex check the full name pattern
            Regex rmob = new Regex("^91-[6-9]{1}[0-9]{9}$");                    //// This Regex check a mobile number where 91-fixed, after that first letter should be 6-9
            string message = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016";
            Console.WriteLine(message);
            Console.WriteLine("Enter first Name: ");
            string name = Console.ReadLine();
            if (rname.IsMatch(name))
            {
                message = message.Replace("<<name>>", name);
                Console.WriteLine("Enter full Name: ");
                string fullname = Console.ReadLine();

                if (rfull.IsMatch(fullname))
                {
                    message = message.Replace("<<full name>>", fullname);
                    Console.WriteLine("Enter Mobile Number: ");
                    string mobno = Console.ReadLine();

                    if (rmob.IsMatch(mobno))
                    {
                        message = message.Replace("91-xxxxxxxxxx", mobno);
                        message = message.Replace("01/01/2016", System.DateTime.Now.ToString("dd/MM/yyyy"));
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine(" invalid Mobile number ");
                    }
                }
                else
                {
                    Console.WriteLine("invalid  Full name");
                }
            }
            else
            {
                Console.WriteLine(" invalid name");
            }
        }
    }
}
