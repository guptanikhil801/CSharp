// -----------------------------------------------------------------------------------------------------------
// <copyright file="LogHelper.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// static class to access Log Method
    /// </summary>
    public static class LogHelper
    {
        /// <summary>
        /// Logs the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="message">The message.</param>
        public static void Log(LogTarget target, string message)
        {
            if (target == LogTarget.File)
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
