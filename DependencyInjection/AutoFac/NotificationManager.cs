using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.AutoFac
{
   public class NotificationManager
    {
        public IMessage msgobj = null;
        public IEmail mailobj = null;
        public NotificationManager(IMessage msg)
        {
            msgobj = msg;
        }
        public IEmail SetEmail
        {
            set
            {
                mailobj = value;
            }
        }
        public void SendNotification()
        {
            msgobj.Execute();
            mailobj.Execute();
        }
    }
}
