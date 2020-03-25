
namespace DesignPattern.Logger
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    public class FileLogger : LogBase
    {
        public string filepath = @"C:\Users\Nikhil Gupta\source\repos\CSharp\DesignPattern\Logger\LogFile.txt";
        public override void Log(string message)
        {
            lock (lockobj)
            {
                using(StreamWriter swriter = new StreamWriter(filepath))
                {
                    swriter.WriteLine(message);
                    swriter.Close();
                }
            }
        }
    }
}
