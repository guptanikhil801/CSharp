// -----------------------------------------------------------------------------------------------------------
// <copyright file="ClientM.cs" company="Bridgelabz">
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
    /// Test class
    /// </summary>
    public class ClientM
    {
        private IService service;

        /// <summary>
        /// takes dependency class as parameter and calls its methods
        /// </summary>
        /// <param name="servicel">The servicel.</param>
        public void Start(IService servicel)
        {
            servicel.Serve();
        }
    }
}
