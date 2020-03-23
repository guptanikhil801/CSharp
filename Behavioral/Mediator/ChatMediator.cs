using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Mediator
{
   public interface IChatMediator
    {
        void AddUser(User user);
        void SendMessage(string msg, User user);
    }
}
