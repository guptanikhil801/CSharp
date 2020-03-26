// -----------------------------------------------------------------------------------------------------------
// <copyright file="MessageService.cs" company="Bridgelabz">
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
    /// implementation class of Message
    /// </summary>
    /// <seealso cref="DesignPattern.DependencyInjection.AutoFac.IMessage" />
    public class MessageService : IMessage
    {
        /// <summary>
        /// to execute email notification
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("you have a new message");
        }
    }
}
