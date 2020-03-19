namespace DesignPattern.Creational.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    interface Computer
    {
        int ramcapacity();
        int hddcapacity();
        string cpu();
        string manufacturer();
    }
}