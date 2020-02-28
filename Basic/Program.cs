namespace Basic
{
    using System;

    /// <summary>
    /// This is the main class of Basic program project.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// It is the main method to call various methods of a class ny using switch case.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1-Factors        2-Flipcoin     3-HarmonicNumber ");
            Console.WriteLine("4-LeapYear       5-PowerOf2     6-StringReplace ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Factors.DriverMethodFactors();
                    break;
                case 2:
                    FlipCoin.DriverMethodFlipCoin();
                    break;

                case 3:
                    HarmonicNumber.DriverMethodHarmonic();
                    break;
                case 4:
                    LeapYear.DriverMethodLeapYear();
                    break;
                case 5:
                    PowerOf2.DriverMethodPowerOf2();
                    break;

                case 6:
                    StringReplace.DriverMethodreplaceString();
                    break;

                default:
                    Console.WriteLine("invalid Choice");
                    break;
            }
        }
    }
}
