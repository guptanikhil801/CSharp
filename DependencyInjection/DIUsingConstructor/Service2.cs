// -----------------------------------------------------------------------------------------------------------
// <copyright file="Service2.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 called");
        }
    }
}
