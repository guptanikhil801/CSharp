using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OopsPrograms.CommercialData
{
    public class Management
    {
        CommercialData cd = new CommercialData();
        public void DriverMethod()
        {
            Console.WriteLine("Enter customer name");
            string cus = Console.ReadLine();
            Console.WriteLine("Enter Path");
            string filepath = Console.ReadLine();
            Console.WriteLine("Enter 1 to dispaly account report\n" +"Enter 2 to remove an account\n" +
              "Enter 3 to Add a New account");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Display(cus);
                    break;
                case 2:
                    RemoveAccount(cus,filepath);
                    break;
                case 3:
                    AddAccount(filepath);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        
        public void AddAccount(string file)
        {
            List<StockAccount> ls;
            if (file.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(file);
            }
            Console.WriteLine("enter the Name of customer: ");
            StockAccount sa = new StockAccount();
            cd.TakeData(Console.ReadLine());
            ls.Add(sa);
            string serial = JsonConvert.SerializeObject(ls);
            File.WriteAllText(file, serial);
            //// writing into file
            using (StreamWriter stream = File.CreateText(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }
            Console.WriteLine("Successfully added");
        }
        public void RemoveAccount(string custname, string file)
        {
            string jfile = File.ReadAllText(file);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].customerName.Equals(custname))
                {
                    ls.Remove(ls[i]);
                    break;
                }
            }

            //// serialization
            using (StreamWriter stream = File.CreateText(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }
            Console.WriteLine("removed successfully");
        }
        public void Display(string custname)
        {

            List<StockAccount> ls;
            ls = JsonConvert.DeserializeObject<List<StockAccount>>(custname);
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].customerName.Equals(custname))
                {
                    cd.PrintReport(custname);
                    break;
                }
            }
        }
    }
}