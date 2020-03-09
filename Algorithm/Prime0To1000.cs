namespace Algorithm
{
    using System;
    using System.Text;

    /// <summary>
    /// This class code to check that a number is prime or not
    /// </summary>
    public class Prime0To1000
    {
        /// <summary>
        /// boolean method to check prime which takes one argument.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>boolean value</returns>
        public static bool CheckPrime(int num)
        {
            int m = num / 2;
            //// the loop will continue till half of number
            for (int i = 2; i <= m; i++)
            {
                //// if number is divisible by i value then returns false
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;       //// otherwise if not divisible then true
        }

        /// <summary>
        /// Drivers  method to check prime within range.
        /// </summary>
        public static void DriverMethodPrimeWithinRange()
        {
            int range1 = 0;
            int range2 = 1000;

            for (int i = range1; i <= range2; i++)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
