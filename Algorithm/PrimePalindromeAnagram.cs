namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains code to check a number is (prime, anagram and palindrome) or not
    /// </summary>
    /// <seealso cref="Algorithm.AnagramDetection" />
    public class PrimePalindromeAnagram : AnagramDetection
    {
        /// <summary>
        /// This method Checks the number is prime or not.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>true or false</returns>
        public static bool CheckPrime(int num)
        {
            int m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// This method Checks a number is palindrome or not.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>true or false</returns>
        public static bool CheckPalindrome(int n)
        {
            int sum = 0;
            int t = n;
            //// loop will continue till value of t is greater than 0 and reverse the number
            while (t > 0)
            {
                int r = t % 10;
                sum = (sum * 10) + r;
                t = t / 10;
            }

            //// if sum is not equal to n then number is not palindrome otherwise it is palindrome
            if (sum != n)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks a integer is anagram or not by first converting it into string and then calling AnagramDetectionString method.
        /// </summary>
        /// <param name="a">int a.</param>
        /// <param name="b">int b.</param>
        /// <returns>true or false</returns>
        public static bool CheckAnagramInteger(int a, int b)
        {
            string str1 = a.ToString();
            string str2 = b.ToString();
            if (AnagramDetectionString(str1, str2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Drivers method to check (prime, palindrome and anagram) from 0 to 1000.
        /// </summary>
        public static void DriverPrimePalindromeAnagram()    // program-8(Algorithm)
        {
            Console.WriteLine("All these numbers are prime, palindrome(first column) and anagram(the number which is in same horizontal line)");
            for (int i = 0; i < 1000; i++)
            {
                if (CheckPrime(i) && CheckPalindrome(i))
                {
                    for (int j = i + 1; j < 1001; j++)
                    {
                        if (CheckAnagramInteger(i, j))
                        {
                            Console.WriteLine(i + " " + j);
                        }
                    }
                }
            }
        }
    }
}
