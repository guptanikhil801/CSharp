namespace Basic
{
    using System;
    using System.Text;

    public class HarmonicNumber
    {
        public static double CalculateHarmonic(double h)
        {
            double har = 0;
            for (double i = 1; i <= h; i++)
            {
                har = har + (1 / i);
            }

            return har;
        }

        /// <summary>
        /// Drivers  method to take input and print nth harmonic number.
        /// </summary>
        public static void DriverMethodHarmonic()
        {
            Console.WriteLine("Enter n ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Harmonic Number is " + CalculateHarmonic(n));
        }
    }
}
