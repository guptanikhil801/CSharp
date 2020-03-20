namespace DesignPattern.Creational.ProtoType
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   public class Distributor
    {
        public string Location { get; set; }
        public List<Vehicle> vehicle { get; set; }
        public void FeedData()
        {
            Vehicle v = new Vehicle();
            v.TypeOfVehicle = "car";
            v.Brand = "Rolce Royce";
            v.Price = 30000000;
            vehicle.Add(v);

            Vehicle va = new Vehicle();
            v.TypeOfVehicle = "car";
            v.Brand = "Mustang";
            v.Price = 10000000;
            vehicle.Add(va);

            Vehicle vb = new Vehicle();
            v.TypeOfVehicle = "Bike";
            v.Brand = "Harley Davidson";
            v.Price = 600000;
            vehicle.Add(vb);

            Vehicle vc = new Vehicle();
            v.TypeOfVehicle = "Bike";
            v.Brand = "Triumph";
            v.Price = 400000;
            vehicle.Add(vc);

        }
    }
}
