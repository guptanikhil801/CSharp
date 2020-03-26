using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection.DIUsingMethod
{
   public class ClientM
    {
        private DIUsingConstructor.IService service;
        public void Start(DIUsingConstructor.IService servicel)
        {
            servicel.Serve();
        }
    }
}
