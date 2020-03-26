
// -----------------------------------------------------------------------------------------------------------
// <copyright file="TestPro.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.DIThroughProperty
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DesignPattern.DependencyInjection.DIUsingConstructor;

    /// <summary>
    /// main class to test DI through property
    /// </summary>
    public class Testpro
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethod()
        {
            Service1 s1 = new Service1();           //// creating object of dependecy 
            ClientPro client = new ClientPro();       
            client.Service = s1;                  //// passing dependency
            Service2 s2 = new Service2();
            client.Service = s2;
        }
    }
}
