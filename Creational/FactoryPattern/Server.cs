namespace DesignPattern.Creational.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Server:Computer
    {
        private int ram;
        private int hdd;
        private string cpu;
        private string manuf;
        Server(int ram, int hdd, string cpu, string manuf)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
            this.manuf = manuf;
        }
        public string cpuname()
        {
            return this.cpu;
        }
        public int hddcapacity()
        {
            return this.hdd;
        }
        public string manufacturer()
        {
            return this.manuf;
        }
        public int ramcapacity()
        {
            return this.ram;
        }
    }
}