﻿namespace OopsPrograms.InventoryData
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    using System.Text.Json.Serialization;
    using System.IO;

    /// <summary>
    /// This is the main class of InventoryData
    /// </summary>
    public class InventoryMain
    {
        public static string SerializationInventory()
        {
            Inventory ivt = new Inventory();
            FoodItems fi = new FoodItems();
            ivt.Rice = new List<FoodItems>();
            fi.Name = "Daawat";
            fi.Price = 145;
            fi.Weight = 10;
            ivt.Rice.Add(fi);

            FoodItems fip = new FoodItems();
            ivt.Pulses = new List<FoodItems>();
            fip.Name = "chickpeas";
            fip.Price = 123;
            fip.Weight = 5;
            ivt.Pulses.Add(fip);

            FoodItems fiw = new FoodItems();
            ivt.Weights = new List<FoodItems>();
            fiw.Name = "Ashirvad";
            fiw.Price = 42;
            fiw.Weight = 10;
            ivt.Weights.Add(fiw);
            Console.WriteLine("serialized and file added");
            string jsonstr = JsonConvert.SerializeObject(ivt, Formatting.Indented);
            string filepath = @"C:\Users\yempc69\source\repos\CSharpMonth1\OopsPrograms\InventoryData\Inventory.json";
            File.WriteAllText(filepath, jsonstr);
            return filepath;
        }
        public static void DeserilizationInventory(string filepath)
        {
            string filestr = File.ReadAllText(filepath);
            Inventory ivf = JsonConvert.DeserializeObject<Inventory>(filestr);
            Console.WriteLine(" after Deserialization data is :");
            foreach (FoodItems fr in ivf.Rice)
            {
                Console.WriteLine(fr);
            }
            foreach (FoodItems fp in ivf.Pulses)
            {
                Console.WriteLine(fp);
            }
            foreach (FoodItems fw in ivf.Weights)
            {
                Console.WriteLine(fw);
            }
        }


    }
}

