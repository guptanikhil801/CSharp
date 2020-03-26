// -----------------------------------------------------------------------------------------------------------
// <copyright file="IService.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 called");
        }
    }
}
