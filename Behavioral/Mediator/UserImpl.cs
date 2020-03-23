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
    public class UserImpl : User
    {
        public UserImpl(IChatMediator med, string name) : base(med,name)
        {
            
        }
        public override void Receive(string msg)
        {
            Console.WriteLine(this.name + " [Received Message] : " + msg);

        }

        public override void Send(string msg)
        {
            Console.WriteLine(this.name + " [Sending Message] : " + msg);
            mediator.SendMessage(msg, this);
        }
    }
}
