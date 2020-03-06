namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Calender
    {
        public static string[] month = { "", "january", "Febuary", "March", "April", "May", "Jun", "July", "August", "September", "October", "November", "December" };
        public static bool IsLeap(int year)
        {
            if ((year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0)))
            {
                return true;
            }

            return false;
        }
        public static int DayOffWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }
        public static int[,] MakeCaleneder(int m, int y)
        {
            int[] daysinmonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeap(y))
            {
                daysinmonth[2] = 29;
            }
            int[,] cal = new int[2, daysinmonth[m] + 1];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < cal.GetLength(1); j++)
                {
                    if (i == 0 && j <= 6)
                    {
                        cal[i, j] = j;
                    }
                    if (i == 1)
                    {
                        cal[i, j] = j;
                    }
                }
            }
            return cal;
        }
    }

}
