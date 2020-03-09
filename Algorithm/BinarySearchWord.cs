namespace Algorithm
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to search a word in a text file by using Binary search
    /// </summary>
    public class BinarySearchWord
    {
        /// <summary>
        /// This method does the binary search by taking two arguments.
        /// </summary>
        /// <param name="strarr">The string type array.</param>
        /// <param name="word">The word.</param>
        /// <returns>Array index at which the word is present</returns>
        public static int BinarySearchString(string[] strarr, string word)
        {
            int low = 0;
            int high = strarr.Length - 1;
            while (low <= high)
            {
                int mid = low + ((high - 1) / 2);
                int cw = word.CompareTo(strarr[mid]);
                if (cw == 0)
                {
                    return mid;
                }
                else if (cw > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// This method call the BinarySearchString method and displays the result.
        /// </summary>
        public static void DriverMethodBinarySearch()      //// program-2(Algorithm)
        {
            string str = System.IO.File.ReadAllText("D:/TextFile.txt");
            string[] arr = str.Split(',');
            Array.Sort(arr);
            string st = "def";
            int res = BinarySearchString(arr, st);
            if (res > -1)
            {
                Console.WriteLine("word found at " + res + " index");
            }
            else
            {
                Console.WriteLine("Word not found");
            }
        }
    }
}
