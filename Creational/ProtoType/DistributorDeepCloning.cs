using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.ProtoType
{
   public class DistributorDeepCloning:DistributorShallowCloning
    {

        public new Object Clone()
        {
            DistributorDeepCloning dpc =(DistributorDeepCloning)this.MemberwiseClone();
            dpc.vehicle = this.vehicle;
            return dpc;
        }
    }
}
