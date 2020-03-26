// -----------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
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
    /// this is the class which has dependency on other classes
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The service type variable for dependent classes
        /// </summary>
        private IService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public Client(IService service)
        {
            this.service = service;
        }

        /// <summary>
        /// for calling methods of dependent class.
        /// </summary>
        public void ServeMethod()
        {
            this.service.Serve();
        }
    }
}
