// -----------------------------------------------------------------------------------------------------------
// <copyright file="IMessage.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------------------------
namespace DesignPattern.DependencyInjection.AutoFac
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interface for Message
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// to execute email notification
        /// </summary>
        void Execute();
    }
}
