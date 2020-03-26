// -----------------------------------------------------------------------------------------------------------
// <copyright file="Service1.cs" company="Bridgelabz">
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
    /// 1st dependent class
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.DIUsingConstructor.IService" />
    public class Service1 : IService
    {
        /// <summary>
        /// method of this class
        /// </summary>
        public void Serve()
        {
            Console.WriteLine("Service1 called");
        }
    }
}
