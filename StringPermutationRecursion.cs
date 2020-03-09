namespace Week1.FunctionalProgrammes
{
    using System;
    using System.Text;

    /// <summary>
    /// This class has code to print possible permutation of a string
    /// </summary>
    public class StringPermutationRecursion
    {
        /// <summary>
        /// This method Swaps the character.
        /// </summary>
        /// <param name="a">string type input</param>
        /// <param name="i">starting index</param>
        /// <param name="j">last index.</param>
        /// <returns>The string</returns>
        public static string SwapChar(string a, int i, int j)
        {
            char temp;                                //// char type temporary variable to swap i and j
            char[] charr = a.ToCharArray();           //// converting string into char array
            temp = charr[i];                         //// swapping
            charr[i] = charr[j];
            charr[j] = temp;
            string st = new string(charr);
            return st;
        }

        /// <summary>
        /// This method Permutes the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="l">The l.</param>
        /// <param name="r">The r.</param>
        public static void Permute(string str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = SwapChar(str, l, i);
                    Permute(str, l + 1, r);
                    str = SwapChar(str, l, i);
                }
            }
        }

        /// <summary>
        /// Drivers method to take string input from user and print possible permutation.
        /// </summary>
        public static void DriverMethodPermutation()
        {
            Console.WriteLine("enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("permutations are");
            int sl = str1.Length - 1;
            Permute(str1, 0, sl);
        }
    }
}
