using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Logger
{
   public class LogTest
    {
        public static void DriverMethod()
        {
            LogHelper.Log(LogTarget.File, "Log Message");
            Console.WriteLine("done");
        }
    }
}
