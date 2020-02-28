namespace JUnitTesting
{
    using System;

    /// <summary>
    /// This is the main class of Junit 
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
            Console.WriteLine("1-VendingMachine      2-DayOffWeek       3-TemperatureConversion      4-MonthlyPayment");
            Console.WriteLine("5-sqrt                6-ToBinary         7-SwapNibbles");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    VendingMachine.DriverMethodVendingM();
                    break;
                case 2:
                    Util.DayOffWeekwithDriver();
                    break;
                case 3:
                    Util.TempConversionWithDriver();
                    break;
                case 4:
                    Util.MonthlyPaymentWithDriver();
                    break;
                case 5:
                    Sqrt.SqrtDriverMethod();
                    break;
                case 6:
                    Console.WriteLine("Enter number to convert to binary");
                    int dnum = int.Parse(Console.ReadLine());
                    Console.WriteLine(Binary.ToBinary(dnum));
                    break;
                case 7:
                    Binary.BinaryDriverMethod();
                    break;
            }
        }
    }
}
