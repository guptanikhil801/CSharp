namespace Basic
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to calculate power of 2 up to n
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// This method calculates and prints power of 2.
        /// </summary>
        public static void DriverMethodPowerOf2()
        {
            Console.WriteLine("Enter number Between 1 and 31 ");
            int num = int.Parse(Console.ReadLine());

            // check the entered input is between 1 to 31
            if (num > 0 && num < 32)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(2 + "^" + i + " = " + Math.Pow(2, i));    //// calculate power using Math.pow method
                }
            }
            else
            {
                Console.WriteLine("num is out of range ");
            }
        }
    }
}
