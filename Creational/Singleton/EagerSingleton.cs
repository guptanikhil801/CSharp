// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Card.cs" company="Bridgelabz">
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
        private EagerSingleton()
        {
            Console.WriteLine("Singleton class created using Eager Initialization ");
        }
        private static EagerSingleton ESInstance = new EagerSingleton();
        public static EagerSingleton getInstanceOfEagerSingleton
        {
            get
            {
                return ESInstance;
            }
        }
    }
}