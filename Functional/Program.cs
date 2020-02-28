namespace Week1.FunctionalProgrammes
{
    using System;
    using System.Text;
    using Functional.FunctionalProgrammes;

    /// <summary>
    /// This is the main class
    /// </summary>
     public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1-Distance     2-windchill       3-SumOfThree     4-TwoDArray     ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Distance.DriverMethodDistance();
                    break;
                case 2:
                    Windchill.DriverMethodWindchill();
                    break;

                case 3:
                    SumOfThree.DriverMethodSumOfThree();
                    break;
                case 4:
                    TwoDArray.DriverMethod2DArray();
                    break;
                default:
                    Console.WriteLine("invalid Choice");
                    break;
            }
        }
    }
}
