using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Mediator
{
   public class ChatClient
    {
        public static void DriverMethodMediator()
        {
            IChatMediator mediator = new ChatMediatorImpl();
            User user1 = new UserImpl(mediator, "Nikhil");
            User user2 = new UserImpl(mediator, "Ashish");
            User user3 = new UserImpl(mediator, "Abhishek");
            User user4 = new UserImpl(mediator, "Rohit");
            User user5 = new UserImpl(mediator, "Sunny");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);
            mediator.AddUser(user5);
            user1.Send("Hello friends");
        }
    }
}
