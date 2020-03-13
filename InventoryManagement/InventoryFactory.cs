namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    public class InventoryM
    {

        /// <summary>
        /// data of Rice
        /// </summary> 
        public List<FoodItemsM> Rice;

        /// <summary>
        /// data of Pulses
        /// </summary>
        public List<FoodItemsM> Pulses;

        /// <summary>
        /// data of weight
        /// </summary>
        public List<FoodItemsM> Wheat;

        public double Sum { get; set; }
    }
    public class FoodItemsM
    {
        /// <summary>
        /// Gets or sets the Name of Rice
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight of Rice
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the price of Rice
        /// </summary>
        public double Price { get; set; }
        public double TotalPrice;

        /// <summary>
        /// to override object 
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}\nTotalPrice:\t{3}", this.Name, this.Price, this.Weight, this.TotalPrice);
        }
    }
    public class InventoryFactory
    {
        public void Add(string filepath)
        {
            string strjason = File.ReadAllText(filepath);
            InventoryM im = JsonConvert.DeserializeObject<InventoryM>(strjason);
            if (im == null)
            {
                im = new InventoryM();
            }
            double sum = 0;
            if (im != null)
            {
                sum = im.Sum;
            }
            FoodItemsM item = new FoodItemsM();
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1:  Rice,    2: pulses,    3: Wheat");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter Price");
            item.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            item.Weight = double.Parse(Console.ReadLine());
            item.TotalPrice = item.Price * item.Weight;
            if (im == null)
            {
                sum = item.TotalPrice;
            }

            else
            {
                sum += item.TotalPrice;
            }

            switch (choice)
            {
                case 1:
                    if (im.Rice == null)
                    {
                        im.Rice = new List<FoodItemsM>();
                    }
                    im.Rice.Add(item);
                    break;
                case 2:
                    if (im.Pulses == null)
                    {
                        im.Pulses = new List<FoodItemsM>();
                    }
                    im.Pulses.Add(item);
                    break;
                case 3:
                    if (im.Wheat == null)
                    {
                        im.Wheat = new List<FoodItemsM>();
                    }
                    im.Wheat.Add(item);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            im.Sum = sum;
            using (StreamWriter writer = File.CreateText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, im);
                Console.WriteLine("New Data Added to the Inventory");
            }
        }
        public void Delete(string filepath)
        {
            string jsonstr = File.ReadAllText(filepath);
            InventoryM im = JsonConvert.DeserializeObject<InventoryM>(jsonstr);
            Console.WriteLine("Which type of inventory you want to delete");
            Console.WriteLine("Enter 1:   Rice,    2:    pulses    3:    wheats");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name you want to delete");
            string nameinven = Console.ReadLine();
            double sum = im.Sum;
            switch (choice)
            {
                case 1:
                    foreach (FoodItemsM f in im.Rice)
                    {
                        if (f.Name.Equals(nameinven))
                        {
                            sum -= f.TotalPrice;
                            im.Rice.Remove(f);
                            break;
                        }
                    }

                    break;
                case 2:
                    foreach (FoodItemsM f in im.Pulses)
                    {
                        if (f.Name.Equals(nameinven))
                        {
                            sum -= f.TotalPrice;
                            im.Pulses.Remove(f);
                            break;
                        }
                    }

                    break;
                case 3:
                    foreach (FoodItemsM f in im.Wheat)
                    {
                        if (f.Name.Equals(nameinven))
                        {
                            sum -= f.TotalPrice;
                            im.Wheat.Remove(f);
                            break;
                        }
                    }

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            im.Sum = sum;
            using (StreamWriter writer = File.CreateText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, im);
                Console.WriteLine("Data removed from the Inventory");
            }

        }

        public void DisplayInventory(string filepath)
        {
            string jsonstr = File.ReadAllText(filepath);
            InventoryM im = JsonConvert.DeserializeObject<InventoryM>(jsonstr);
            //Console.WriteLine("Enter your choice");
            Console.WriteLine("json file as a String:");
            Console.WriteLine(jsonstr);
            Console.WriteLine("Total Inventory cost : " + im.Sum);
        }

    }
}
