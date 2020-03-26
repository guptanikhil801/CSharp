// -----------------------------------------------------------------------------------------------------------
// <copyright file="FileLogger.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------


namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Client
    {
        private IService service;
        public Client(IService service)
        {
            this.service = service;
        }
        public void ServeMethod()
        {
            this.service.Serve();
        }
    }
}
