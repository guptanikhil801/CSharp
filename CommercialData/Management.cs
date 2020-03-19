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
            
        }
        public void RemoveAccount()
        {

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
    }
}
