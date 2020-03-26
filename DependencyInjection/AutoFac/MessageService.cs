using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.AutoFac
{
    public class MessageService : IMessage
    {
        public void Execute()
        {
            Console.WriteLine("you hava a new message");
        }
    }
}
