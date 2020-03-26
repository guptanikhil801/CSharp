// -----------------------------------------------------------------------------------------------------------
// <copyright file="DITest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.DIUsingMethod
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DesignPattern.DependencyInjection.DIUsingConstructor;

    /// <summary>
    /// main class to test DI using method
    /// </summary>
    public class DITest
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            Service1 s1 = new Service1();     //// creating object of dependecy 
            ClientM client = new ClientM();
            client.Start(s1);                //// passing dependency and calling method
            Service2 s2 = new Service2();
            client.Start(s2);
        }
    }
}
