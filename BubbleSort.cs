namespace Algorithm
{
    using System;
    using System.Text;

    /// <summary>
    /// This class has code to sort the integer in an array by using bubble sort Algorithm
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// This method takes integer type array and does sorting.
        /// </summary>
        /// <param name="intarr">The integer type array.</param>
        /// <returns>sorted integer array</returns>
        public static int[] DoBubbleSort(int[] intarr)
        {
            for (int i = 0; i < intarr.Length; i++)
            {
                int temp;
                for (int j = 0; j < intarr.Length - 1; j++)
                {
                    if (intarr[j] > intarr[j + 1])
                    {
                        temp = intarr[j];
                        intarr[j] = intarr[j + 1];
                        intarr[j + 1] = temp;
                    }
                }
            }

            return intarr;
        }

        /// <summary>
        /// Drivers method to take integer in an array and after that sort the array by calling above method.
        /// </summary>
        public static void DriverBubbleSort()         // program-4(Algorithm)
        {
            Console.WriteLine("enter Array size");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];
            Console.WriteLine("Enter integer numbers one by one ");
            for (int i = 0; i < l; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            DoBubbleSort(arr);
            for (int j = 0; j < l; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
