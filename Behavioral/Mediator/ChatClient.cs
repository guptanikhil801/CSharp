// -------------------------------------------------------------------------------------------------------
// <copyright file="ChatClient.cs" company="Bridgelabz">
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
    /// main driver class to check Mediator design pattern
    /// </summary>
    public class ChatClient
    {
        /// <summary>
        /// Driver method.
        /// </summary>
        public static void DriverMethodMediator()
        {
            IChatMediator mediator = new ChatMediatorImpl();
            User user1 = new UserImpl(mediator, "Nikhil");
            User user2 = new UserImpl(mediator, "Ashish");
            User user3 = new UserImpl(mediator, "Abhishek");     //// creating user objects
            User user4 = new UserImpl(mediator, "Rohit");
            User user5 = new UserImpl(mediator, "Sunny");
            mediator.AddUser(user1);
            mediator.AddUser(user2);         //// adding user to mediator
            mediator.AddUser(user3);
            mediator.AddUser(user4);
            mediator.AddUser(user5);
            user1.Send("Hello friends");     //// message to be sent to all user except user1 itself
        }
    }
}
