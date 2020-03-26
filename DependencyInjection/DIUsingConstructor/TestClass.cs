// -----------------------------------------------------------------------------------------------------------
// <copyright file="TestClass.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// main class to test dependency injection using constructor
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            Service1 s1 = new Service1();     //// creating object of dependecy 
            Client c1 = new Client(s1);       //// passing dependency
            c1.ServeMethod();                 //// calling method
            Service2 s2 = new Service2();
            Client c2 = new Client(s2);
            c2.ServeMethod();
        }
    }
}
