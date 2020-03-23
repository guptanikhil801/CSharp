// -------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediator.cs" company="Bridgelabz">
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
    /// interface of ChatMediator
    /// </summary>
    public interface IChatMediator
    {
        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void AddUser(User user);

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        /// <param name="user">The user.</param>
        void SendMessage(string msg, User user);
    }
}
