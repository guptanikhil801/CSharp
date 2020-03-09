namespace Week1.FunctionalProgrammes
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to check in an int array find triplets that sums equal to zero
    /// </summary>
     public class SumOfThree
    {
        /// <summary>
        /// Drivers method to take input integers and calculate sum of three.
        /// </summary>
        public static void DriverMethodSumOfThree()
        {
            Console.WriteLine("enter number of elements ");
            int s = int.Parse(Console.ReadLine());
            int[] intarr = new int[s];
            Console.WriteLine("Enter Array Elements");

            for (int k = 0; k < s; k++)
            {
                intarr[k] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("sum of three adds to zero are :");

            for (int i = 0; i < s - 2; i++)
            {
                for (int j = i + 1; j < s - 1; j++)
                {
                    for (int k = j + 1; k < s; k++)
                    {
                        if (intarr[i] + intarr[j] + intarr[k] == 0)
                        {
                            Console.WriteLine(intarr[i] + " " + intarr[j] + " " + intarr[k]);
                        }
                    }
                }
            }
        }
    }
}
