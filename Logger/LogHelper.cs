
namespace DesignPattern.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public static class LogHelper
    {
        public static void Log(LogTarget target, string message)
        {
            if(target==LogTarget.File)
            {
                FileLogger loger = new FileLogger();
                loger.Log(message);
            }
            else
            {
                return;
            }
        }
    }
}
