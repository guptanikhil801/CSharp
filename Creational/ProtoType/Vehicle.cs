namespace DesignPattern.Creational.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Vehicle : ICloneable
    {
        public string TypeOfVehicle { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
