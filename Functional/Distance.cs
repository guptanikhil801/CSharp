namespace Week1.FunctionalProgrammes
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to calculate distance between two points
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// this method Calculates the distance by taking two double type arguments
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>The distance</returns>
        public static double CalculateDistance(double x, double y)
        {
            double hd = Math.Pow(x, x) + Math.Pow(y, y);                  //// using Math.pow method to calculate power
            double dis = Math.Sqrt(hd);
            return dis;
        }

        /// <summary>
        /// Drivers method to take x and y as input and calculate distance by calling above method
        /// </summary>
        public static void DriverMethodDistance()
        {
            Console.WriteLine("Enter x ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Distance : " + CalculateDistance(x, y));
        }
    }
}
