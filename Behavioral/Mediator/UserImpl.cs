// -------------------------------------------------------------------------------------------------------
// <copyright file="UserImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Behavioral.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// implementation class of user
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Mediator.User" />
    public class UserImpl : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImpl"/> class.
        /// </summary>
        /// <param name="med">The mediator.</param>
        /// <param name="name">The name.</param>
        public UserImpl(IChatMediator med, string name) : base(med, name)
        {
        }

        /// <summary>
        /// Receives the specified Message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Receive(string msg)
        {
            Console.WriteLine(this.name + " [Received Message] : " + msg);
        }

        /// <summary>
        /// Sends the specified Message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Send(string msg)
        {
            Console.WriteLine(this.name + " [Sending Message] : " + msg);
            mediator.SendMessage(msg, this);
        }
    }
}
