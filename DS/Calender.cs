namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Calender
    {
        public static bool IsLeap(int year)
        {
            if ((year % 400 == 0) || ((year % 100 !=  0) && (year % 4 == 0)))
            {
                return true;
            }

            return false;
        }

    }
}
