// -------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="Bridgelabz">
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
    /// Abstract user class
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// The IChatmediator type mediator
        /// </summary>
        protected IChatMediator mediator;

        /// <summary>
        /// The name of user
        /// </summary>
        protected string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="med">The mediator.</param>
        /// <param name="name">The name.</param>
        public User(IChatMediator med, string name)
        {
            this.mediator = med;
            this.name = name;
        }

        /// <summary>
        /// Sends the specified Message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Send(string msg);

        /// <summary>
        /// Receives the specified Message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Receive(string msg);
    }
}
