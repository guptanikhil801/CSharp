// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazySingleton.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------------------- 
namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Example of singleton class using Lazy initialization
    /// </summary>
    public sealed class LazySingleton
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="LazySingleton"/> class from being created.
        /// </summary>
        private LazySingleton()
        {
            Console.WriteLine("Singleton class created using Lazy Initialization ");
        }

        /// <summary>
        /// The ls instance
        /// </summary>
        private static readonly Lazy<LazySingleton> LSInstance = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        /// Gets the instance of lazy singleton.
        /// </summary>
        /// <value>
        /// instance of lazySingleton.
        /// </value>
        public static LazySingleton GetInstanceOfLazySingleton
        {
            get
            {
                return LSInstance.Value;
            }
        }
    }
}
