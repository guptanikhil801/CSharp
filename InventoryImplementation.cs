namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    public class InventoryM : InventoryData.Inventory
    {
        public double Sum { get; set; }
    }
    public class FoodItemsM : InventoryData.FoodItems
    {
        public double TotalPrice;
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}\nTotalPrice:\t{3}", this.Name, this.Price, this.Weight, this.TotalPrice);
        }
    }
    public class InventoryImplementation
    {
        public void Add(string filepath)
        {
            string strjason = File.ReadAllText(filepath);
            InventoryM im = JsonConvert.DeserializeObject<InventoryM>(strjason);
            if(im==null)
            {
                im = new InventoryM();
            }
          double sum = 0;
            if(im!=null)
            {
                sum = im.Sum;
            }
            FoodItemsM item = new FoodItemsM();
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1:  Rice,    2: pulses,    3: Weights");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter Price");
            item.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            item.Weight = double.Parse(Console.ReadLine());
            item.TotalPrice = item.Price * item.Weight;
            if(im==null)
            {
                sum = item.TotalPrice;
            }
        }
    }
}
