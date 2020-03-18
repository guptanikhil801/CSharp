// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerSingleton.cs" company="Bridgelabz">
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
    /// Example of singleton class using Eager initialization
    /// </summary>
    public sealed class EagerSingleton
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerSingleton"/> class from being created.
        /// </summary>
        private EagerSingleton()
        {
            Console.WriteLine("Singleton class created using Eager Initialization ");
        }

        /// <summary>
        /// To create instance
        /// </summary>
        private static EagerSingleton esinstance = new EagerSingleton();
       
        /// <summary>
        /// Gets the instance of eager singleton.
        /// </summary>
        /// <value>
        /// instance
        /// </value>
        public static EagerSingleton GetInstanceOfEagerSingleton
        {
            get
            {
                return esinstance;
            }
        }
    }
}