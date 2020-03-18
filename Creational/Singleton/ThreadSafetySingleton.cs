// -----------------------------------------------------------------------------
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
    /// Example of singleton class with Thread Safety
    /// </summary>
    public class ThreadSafetySingleton
    {
        /// <summary>
        /// The object
        /// </summary>
        private static readonly object obj = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafetySingleton"/> class from being created.
        /// </summary>
        private ThreadSafetySingleton()
        {
            Console.WriteLine("Singleton class created with thread safety using double lock");
        }

        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafetySingleton TSInstance = null;

        /// <summary>
        /// Gets the instance of thread safety singleton class by using double call
        /// </summary>
        /// <value>
        /// The instance
        /// </value>
        public static ThreadSafetySingleton GetInstanceOfThreadSafetySingleton
        {
            get
            {
                if(TSInstance==null)
                {
                    lock(obj)
                    {
                        if(TSInstance==null)
                        {
                            TSInstance = new ThreadSafetySingleton();
                        }
                    }
                }
                return TSInstance;
            }
        }
    }
}
