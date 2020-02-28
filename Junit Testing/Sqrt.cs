namespace JUnitTesting
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to calculate square root of a number
    /// </summary>
    public class Sqrt
    {
        /// <summary>
        /// this method Calculates square roots by using epsilon value and specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>double type square root</returns>
        public static double Calculatesqrt(double c)       // programme-5(junit)
        {
            double t = c;
            double epsilon = 1e-15;

            while (Math.Abs(t - (c / t)) > (epsilon * t))
            {
                t = ((c / t) + t) / 2.0;
            }

            return t;
        }

        /// <summary>
        /// the driver method to take number from user and calculate square root by calling above method.
        /// </summary>
        public static void SqrtDriverMethod()
        {
            Console.WriteLine("Enter Number to calculate sqrt");
            double cinp = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculatesqrt(cinp));
        }
    }
}
