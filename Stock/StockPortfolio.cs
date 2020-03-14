// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms.Stock
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    public class StockPortfolio
    {
        public void Add(string filepath)
        {
            string strjason = File.ReadAllText(filepath);
            Portfolio po = JsonConvert.DeserializeObject<Portfolio>(strjason);
            if (po == null)
            {
                po = new Portfolio();
            }
            double PortfolioValue = 0;
            if (po != null)
            {
                PortfolioValue = po.Portfoliovalue;
            }
            Stock st = new Stock();

            Console.WriteLine("Enter Share Name");
            st.ShareName = Console.ReadLine();
            Console.WriteLine("Enter Price of Share");
            st.SharePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Number of Shares");
            st.Numberofshare = int.Parse(Console.ReadLine());
            st.Stockvalue = st.Numberofshare * st.SharePrice;
            if (st == null)
            {
                PortfolioValue = st.Stockvalue;
            }

            else
            {
                PortfolioValue += st.Stockvalue;
            }
            if (po.Portfoliodata == null)
            {
                po.Portfoliodata = new List<Stock>();
            }
            po.Portfoliodata.Add(st);
            po.Portfoliovalue = PortfolioValue;

            Console.WriteLine("stock details Successfully added");
            string jsoncontact = JsonConvert.SerializeObject(po, Formatting.Indented);
            File.WriteAllText(filepath, jsoncontact);
        }

        public void GetValueOfStockAndPortfolio(string filepath)
        {
            string strjason = File.ReadAllText(filepath);
            Portfolio po = JsonConvert.DeserializeObject<Portfolio>(strjason);
            Console.WriteLine("Total Portfolio value is : " + po.Portfoliovalue);
            Console.WriteLine("These are the list of share you have :");
            Stock sk = new Stock();
            foreach (Stock c in po.Portfoliodata)
            {
                Console.Write(c.ShareName + ",      ");
            }

            Console.WriteLine("Enter share name to get stock value  : ");
            string sharen = Console.ReadLine();

            foreach (Stock c in po.Portfoliodata)
            {
                if (c.ShareName.Equals(sharen))
                {
                    Console.WriteLine("stock value is : " + c.Stockvalue);
                    break;
                }
            }

        }
    }
}
