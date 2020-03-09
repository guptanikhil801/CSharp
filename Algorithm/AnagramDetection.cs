namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains code to check two string is anagram or not
    /// </summary>
    public class AnagramDetection
    {
        /// <summary>
        /// This method check two string is anagram or not by converting it to char array and then sorting and checks.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>bool value true or false</returns>
        public static bool AnagramDetectionString(string str1, string str2)
        {
            //// check the length of both string
            if (str1.Length != str2.Length)
            {
                return false;                       //// if length is not same return false
            }

            //// convert both string into character array and sort array using Array.sort method
            char[] chstr1 = str1.ToCharArray();
            char[] chstr2 = str2.ToCharArray();
            Array.Sort(chstr1);
            Array.Sort(chstr2);

            //// After sorting check the value at both array index is same or not 
            for (int i = 0; i < chstr1.Length; i++)
            {
                if (chstr1[i] != chstr2[i])
                {
                    return false;                   //// if value is not same return false
                }
            }

            return true;                            //// if value is same return true
        }

        /// <summary>
        /// Drivers  method to take two input and check anagram .
        /// </summary>
        public static void DriverMethodAnagramString()  //// program-6(Algorithm)
        {
            Console.WriteLine("Enter 1st and second word ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (AnagramDetectionString(str1, str2))
            {
                Console.WriteLine("It is Anagram ");
            }
            else
            {
                Console.WriteLine("it is not anagram");
            }
        }
    }
}
