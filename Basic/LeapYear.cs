/// <summary>
/// This code is created by Nikhil Gupta for Fellowship in Bridgelabz.
/// </summary>
namespace Basic
{
    using System;
    using System.Text;

    /// <summary>
    /// This class contains code to check whether a year is Leap or Not.
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Drivers  method to take year as input and calculate leap year.
        /// </summary>
        public static void DriverMethodLeapYear()
        {
            Console.WriteLine("Enter Year to check ");
            int year = int.Parse(Console.ReadLine());

            //// Logic to check Leap Year
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("Leap Year");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("Leap Year ");
            }
            else
            {
                Console.WriteLine("Not a Leap Year ");
            }
        }
    }
}
