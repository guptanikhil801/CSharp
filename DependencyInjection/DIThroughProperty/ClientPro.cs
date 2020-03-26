using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.DependencyInjection.DIUsingConstructor;

namespace DesignPattern.DependencyInjection.DIThroughProperty
{
   public class ClientPro
    {
        private IService servicep;
        public IService Service
        {
            set
            {
                this.servicep = value;
            }
        }
        public void ServeMethod()
        {
            servicep.Serve();
        }
    }
}
