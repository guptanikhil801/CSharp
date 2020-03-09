namespace Algorithm
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to sort a string
    /// </summary>
    public class InsertionSortString
    {
        /// <summary>
        /// This method Sorts the string using insertion sort algorithm.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>String after sorting</returns>
        public static string[] SortUsingInsertion(string str)
        {
            string[] strarr = str.Split(' ');         //// it first split the string after every space and stores into strarr.
            string key;

            int i, j;
            for (j = 1; j < strarr.Length; j++)
            {
                key = strarr[j];                    // taking array value into key
                i = j - 1;
                while (i >= 0)
                {
                    if (key.CompareTo(strarr[i]) > 0)
                    {
                        break;
                    }

                    strarr[i + 1] = strarr[i];
                    i--;
                }

                strarr[i + 1] = key;
            }

            return strarr;
        }

        /// <summary>
        /// Drivers method to take string type input and display output after sorting.
        /// </summary>
        public static void DriverMethodInsertion()         ////Program-3(Algorithm)
        {
            Console.WriteLine("Enter string sentence to sort ");
            string str1 = Console.ReadLine();
            string[] strarr = SortUsingInsertion(str1);

            for (int k = 0; k < strarr.Length; k++)
            {
                Console.Write(strarr[k] + " ");
            }
        }
    }
}
