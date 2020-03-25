// -----------------------------------------------------------------------------------------------------------
// <copyright file="LogBase.cs" company="Bridgelabz">
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
    /// abstract LogBase class
    /// </summary>
    public abstract class LogBase
    {
        /// <summary>
        /// The lock object to synchronize
        /// </summary>
        protected readonly object Lockobj = new object();

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Log(string message);
    }
}
