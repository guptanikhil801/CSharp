namespace Functional.FunctionalProgrammes
{
    using System;
    using System.Text;

    /// <summary>
    /// This class has code to calculate windchill
    /// </summary>
    public class Windchill
    {
        /// <summary>
        /// This method Calculates the windchill using a formula and Math.pow method.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="v">The v.</param>
        /// <returns>The windchill</returns>
        public static double CalculateWindchill(double t, double v)
        {
            double w = (35.74 + (0.6215 * t)) + ((0.4275 * t - 35.75) * Math.Pow(v, 0.16));
            return w;
        }

        /// <summary>
        /// Driver method to take t and v from user and calculate windchill by calling above method.
        /// </summary>
        public static void DriverMethodWindchill()
        {
            Console.WriteLine("Enter t and v ");
            double t = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            if (t < 51 && v > 2 && v < 121)
            {
                Console.WriteLine("WindChill : " + CalculateWindchill(t, v));
            }
            else
            {
                Console.WriteLine("Enter valit t (below 51) and v (between 3 to 120)");
            }
        }
    }
}
