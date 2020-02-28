namespace Logical
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains code to calculate elapsed time in stopwatch
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// driver method to display elapsed time in stopwatch.
        /// </summary>
        public static void DriverMethodStopwatch()
        {
            Console.WriteLine("Enter any number to start the watch");
            int n = int.Parse(Console.ReadLine());
            long stime = System.DateTime.Now.Hour * 60 + System.DateTime.Now.Minute * 60 + System.DateTime.Now.Second;
            Console.WriteLine("Stop Watch started at " + System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute + ":" + System.DateTime.Now.Second);

            Console.WriteLine("Enter any number to stop the watch");
            int n2 = int.Parse(Console.ReadLine());
            long etime = (System.DateTime.Now.Hour * 60) + (System.DateTime.Now.Minute * 60) + (System.DateTime.Now.Second);
            Console.WriteLine("Stop Watch stopped at " + System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute + ":" + System.DateTime.Now.Second);
            long elapsed = etime - stime;
            Console.WriteLine("total elapsed time = " + elapsed + " second");
        }
    }
}
