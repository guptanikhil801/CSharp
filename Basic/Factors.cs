namespace Basic
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to print prime factors of a number
    /// </summary>
    public class Factors
    {
        /// <summary>
        /// This method Prints the factors by taking a integer type argument n
        /// </summary>
        /// <param name="n">The n.</param>
        public static void PrintFactors(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
            }

            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Drivers method to take input from user and prints factor by calling PrintFactors method
        /// </summary>
        public static void DriverMethodFactors()
        {
            Console.WriteLine("enter number to print its factors ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors are :");
            PrintFactors(n);
        }
    }
}
