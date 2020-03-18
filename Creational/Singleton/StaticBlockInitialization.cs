// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StaticBlockInitialization.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------
namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Example of singleton class using StaticBlockInitialization
    /// </summary>
    public class StaticBlockInitialization
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static StaticBlockInitialization sInstance;

        /// <summary>
        /// Prevents a default instance of the <see cref="StaticBlockInitialization"/> class from being created.
        /// </summary>
        private StaticBlockInitialization()
        {
            Console.WriteLine("singleton design pattern using static block");
        }

        /// <summary>
        /// static block for instance of class.
        /// </summary>
        static StaticBlockInitialization()
        {
            sInstance = new StaticBlockInitialization();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>the instance</returns>
        public static StaticBlockInitialization GetInstance()
        {
            return sInstance;
        }
    }
}