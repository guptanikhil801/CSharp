namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json.Linq;
    public class Inventory
    {
       public class Rice
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }
        public class Pulses
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }

      public  class Wheats
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }

    }
}
