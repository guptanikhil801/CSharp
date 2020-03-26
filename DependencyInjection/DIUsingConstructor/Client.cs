using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.DIUsingConstructor
{
   public class Client
    {
        private IService service;
        public Client(IService service)
        {
            this.service = service;
        }
        public void ServeMethod()
        {
            this.service.Serve();
        }
    }
}
