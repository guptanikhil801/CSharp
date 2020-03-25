// -----------------------------------------------------------------------------------------------------------
// <copyright file="LogTarget.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// --------------------------------------------------------------------------------------------------------
namespace DesignPattern.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// for testing logger
    /// </summary>
    public class LogTest
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            LogHelper.Log(LogTarget.File, "Log Message");
            Console.WriteLine("done");
        }
    }
}
