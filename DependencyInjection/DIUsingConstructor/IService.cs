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

    /// <summary>
    /// interface for dependent class
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Serves this instance.
        /// </summary>
        void Serve();
    }
}
