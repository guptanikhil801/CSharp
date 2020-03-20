namespace DesignPattern.Creational.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public class DistributorShallowCloning:ICloneable
    {
        public string Location;
        public Vehicle vehicle;
        
        public override string ToString()
        {
            return "Location : " + this.Location + "vehicle Details " + this.vehicle;
        }
       public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}