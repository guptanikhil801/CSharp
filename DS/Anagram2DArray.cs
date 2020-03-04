namespace DataStructure.DS_Programmes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Anagram2DArray
    {
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

    }
}
