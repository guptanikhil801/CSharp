
namespace DesignPattern.Behavioral.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public abstract class User
    {
        protected IChatMediator mediator;
        protected string name;
        public User(IChatMediator med, string name)
        {
            mediator = med;
            this.name = name;
        }
        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}
