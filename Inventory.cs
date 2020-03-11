namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json.Linq;
    public class Inventory
    {
        class Rice
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }
        class Pulses
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }

        class Wheats
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public double Price { get; set; }
        }

    }
}
