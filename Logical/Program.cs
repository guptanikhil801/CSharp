namespace Logical
{
    using System;

    /// <summary>
    /// This is the main class of Logical programs
    /// </summary>    
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice : ");
            Console.WriteLine("1-CouponNumbers       2-Gambler      3-StopWatch      4-TicTacToe");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CouponNumbers.DriverCoupon();
                    break;
                case 2:
                    Gambler.DriverMethodGambler();
                    break;
                case 3:
                    StopWatch.DriverMethodStopwatch();
                    break;
                case 4:
                    TicTacToe.DriverMethodTictac();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
