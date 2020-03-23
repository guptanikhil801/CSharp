
namespace DesignPattern.Behavioral.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ChatMediatorImpl : IChatMediator
    {
        private List<User> users;
        public ChatMediatorImpl()
        {
            this.users = new List<User>();
        }
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (User us in this.users)
            {
                if(us!=user)
                {
                    us.Receive(msg);
                }
            }
        }
    }
}
