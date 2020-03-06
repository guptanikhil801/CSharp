namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains code to print a calender using 2D Array
    /// </summary>
    public class Calender
    {
        public static string[] monthstr = { "", "january", "Febuary", "March", "April", "May", "Jun", "July", "August", "September", "October", "November", "December" };

        /// <summary>
        /// This method checks a year is leap year or not
        /// </summary>
        /// <param name="year">year to be checked</param>
        /// <returns></returns>
        public static bool IsLeap(int year)
        {
            if ((year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0)))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// it returns day of week in number like 0 for sunday
        /// </summary>
        /// <param name="d">the date</param>
        /// <param name="m">the month</param>
        /// <param name="y">the year</param>
        /// <returns>the day number</returns>
        public static int DayOffWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }


        public static int MonthLength(int month, int year)
        {
            
            int monthdays=0;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                monthdays = 31;
            }
            else if (month == 4 || month == 6 || month == 8 || month == 11)
            {
                monthdays = 30;
            }
            else if (IsLeap(year))
            {
                if (month == 2)
                {
                    monthdays = 29;
                }
            }
            else if (month == 2)
            {
                monthdays = 28;
            }
            return monthdays;
        }

        /// <summary>
        /// Thid method make a whole month calender 
        /// </summary>
        /// <param name="m">the month</param>
        /// <param name="y">the yea</param>
        /// <returns>whole calender</returns>
        public static int[,] MakeCalender(int mon, int ye)
        {

            int md = MonthLength(mon, ye);

            int [,] cal = new int[1, md];
            for (int k = 1; k <= md; k++)
            {
                for (int i = 0; i < cal.GetLength(0); i++)
                {
                    for (int j = 0; j < cal.GetLength(1); j++)
                    {
                        cal[i, j] = k;
                        k++;
                    }
                }
            }

            return cal;
        }

        public static void DisplayArray(int[,] arr, int mo, int yea)
        {
            int ml = MonthLength(mo, yea);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0&& arr[i,j]<=ml)
                    {
                        if(j%6==0)
                        {
                            Console.WriteLine();
                        }
                        if (arr[i, j] < 10)
                        {
                            Console.Write(arr[i, j] + "  ");
                        }
                        else
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                                                                             //// for printing value
                    }
                }

                
            }
        }

        public static void DriverCalender()
        {
            Console.WriteLine("Enter month");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year ");
            int year = int.Parse(Console.ReadLine());
            int sp = DayOffWeek(1, month, year);
            Console.Clear();
           
            char[] week = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };

            
            int[,] ar = MakeCalender(month, year);
            Console.WriteLine(monthstr[month] + "   " + year);
            for (int i = 0; i < week.Length; i++)
            {
                Console.Write(week[i] + " ");
            }
            Console.WriteLine();
            
            for (int a = 0;a<sp;a++)
            {
                Console.Write("  ");
            }
            
            DisplayArray(ar,month,year);

        }

    }


}

