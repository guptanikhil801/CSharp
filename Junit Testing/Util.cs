// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Util.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------------------
namespace JUnitTesting
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains three code, first to print day of week as a integer value and second for temperature conversion
    /// and third to calculate monthly payment(EMI)
    /// </summary>
  public class Util
    {
        /// <summary>
        /// This method prints Day of week by taking data from user and calculates using formula.
        /// </summary>
        public static void DayOffWeekwithDriver()   ////programme-2(junit)
        {
            Console.WriteLine("Enter date ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month(1-12) ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year (in 4 digit) ");
            int y = int.Parse(Console.ReadLine());

            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = (m + (12 * (14 - m) / 12)) - 2;
            int d0 = (d + x + (31 * (m0 / 12))) % 7;

            Console.WriteLine("dayoffweek : " + d0);
        }

        /// <summary>
        /// this method converts temperature from celsius to fahrenheit and vice versa
        /// </summary>
        public static void TempConversionWithDriver()         ////programme-3(junit)
        {
            Console.WriteLine("Enter Temperature");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter f to convert to forhenheit, c to convert to celcius");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'f':
                    double fer = (temp * 9 / 5) + 32;
                    Console.WriteLine("Temperature in farenheit : " + fer);
                    break;

                case 'c':
                    double cel = (temp - 32) * 5 / 9;
                    Console.WriteLine("Temperature in celcius : " + cel);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }

        /// <summary>
        /// this method calculates monthly payment by taking p,r,y from user
        /// </summary>
        public static void MonthlyPaymentWithDriver()       //// programme-4(junit)
        {
            Console.WriteLine("Enter Principal amount, interest Rate and  Year");
            double pa = double.Parse(Console.ReadLine());
            double ri = double.Parse(Console.ReadLine());
            double ye = double.Parse(Console.ReadLine());

            double n = 12 * ye;
            double r = ri / 1200;
            double payment = pa * (r / 1) - Math.Pow(1 + r, -n);

            Console.WriteLine("Monthly payment will be: " + payment);
        }
    }
}
