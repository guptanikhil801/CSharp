// -------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediatorImpl.cs" company="Bridgelabz">
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
    /// implementation class of IChatMediator
    /// </summary>
    /// <seealso cref="DesignPattern.Behavioral.Mediator.IChatMediator" />
    public class ChatMediatorImpl : IChatMediator
    {
        /// <summary>
        /// The list of users
        /// </summary>
        private List<User> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMediatorImpl"/> class.
        /// </summary>
        public ChatMediatorImpl()
        {
            this.users = new List<User>();
        }

        /// <summary>
        /// concrete method of Adduser.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// concrete method of Sendmessage.
        /// </summary>
        /// <param name="msg">The Message.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string msg, User user)
        {
            foreach (User us in this.users)
            {
                if (us != user)
                {
                    us.Receive(msg);
                }
            }
        }
    }
}
