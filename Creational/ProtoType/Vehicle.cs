namespace DesignPattern.Creational.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return "Vehicle Type, : " + TypeOfVehicle + ", Brand : " + Brand + " Price : " + Price;
        }
    }
}
