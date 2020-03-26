// -----------------------------------------------------------------------------------------------------------
// <copyright file="ClientPro.cs" company="Bridgelabz">
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
    /// class which has dependency on other classes
    /// </summary>
    public class ClientPro
    {
        private IService servicep;

        /// <summary>
        /// Sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        public IService Service
        {
            set
            {
                this.servicep = value;
            }
        }

        /// <summary>
        /// calls method of dependent class
        /// </summary>
        public void ServeMethod()
        {
            this.servicep.Serve();
        }
    }
}
