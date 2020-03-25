// -----------------------------------------------------------------------------------------------------------
// <copyright file="FileLogger.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.Logger
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// for logging of file, concrete class of LogBase
    /// </summary>
    /// <seealso cref="DesignPattern.Logger.LogBase" />
    public class FileLogger : LogBase
    {
        /// <summary>
        /// The address of file in which logs will be stored
        /// </summary>
        public string Filepath = @"C:\Users\Nikhil Gupta\source\repos\CSharp\DesignPattern\Logger\Logfile.txt";

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void Log(string message)
        {
            lock (this.lockobj)
            {
                using (StreamWriter swriter = new StreamWriter(this.Filepath))
                {
                    swriter.WriteLine(message);
                    swriter.Close();
                }
            }
        }
    }
}