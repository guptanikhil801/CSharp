namespace DesignPattern.Creational.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Vehicle:ICloneable
    {
        public string Typeofvehicle;
        public string Brand;
        public int Price;

        public Vehicle(string typeofvehicle, string brand, int price)
        {
            Typeofvehicle = typeofvehicle;
            Brand = brand;
            Price = price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Vehicle Type, : " + this.Typeofvehicle + ", Brand : " + this.Brand + " Price : " + this.Price;
        }
    }
}