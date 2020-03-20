using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.ProtoType
{
    public class ProtoTypeRunnerClass
    {
        public static void DriverMethod()
        {
            DistributorShallowCloning sc = new DistributorShallowCloning();
            sc.Location = "Bangalore";
            sc.vehicle = new Vehicle("Car", "Rolls Roycse", 45000000);
            Console.WriteLine("Original object of shallow cloning");
            Console.WriteLine(sc);
            DistributorShallowCloning clonedshallow = (DistributorShallowCloning)sc.Clone();
            clonedshallow.Location = "Ranchi";
            Console.WriteLine("Cloned object using shallow cloning");
            Console.WriteLine(clonedshallow);
            DistributorDeepCloning dc = new DistributorDeepCloning();
            sc.Location = "Jamshedpur";
            sc.vehicle = new Vehicle("Car", "fortuner", 3500000);
            Console.WriteLine("Original object of Deep cloning");
            Console.WriteLine(dc);
            DistributorDeepCloning cloneddeep = (DistributorDeepCloning)dc.Clone();
            cloneddeep.Location = "Hyderabad";
            Console.WriteLine("Cloned object using deep cloning");
            Console.WriteLine(cloneddeep);

        }
    }
}
