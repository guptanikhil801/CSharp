// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommercialData.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------
namespace OopsPrograms.CommercialData
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// commercial data class
    /// </summary>
    public class CommercialData
    {
        StockAccount sa = new StockAccount();

        /// <summary>
        /// Takes the data.
        /// </summary>
        /// <param name="customername">The customer name.</param>
        public void TakeData(string customername)
        {
            this.sa.customerName = customername;
            Console.WriteLine("In How many company's stock u want to do transaction");
            int numo = int.Parse(Console.ReadLine());
            this.sa.numberofStocks = numo;
            this.sa.transactiontime = DateTime.Now;
            for (int i = 0; i < sa.numberofStocks; i++)
            {
                List<string> sn = new List<string>();//sa.shareName 
                List<int> sp = new List<int>(); //sa.sharePrice = 
                List<int> nus = new List<int>();// number of share
                int[] arramt = new int[numo];
                List<string> tt = new List<string>();
                Console.WriteLine("Enter Name of share i..e company name");
                sn.Add(Console.ReadLine());
                Console.WriteLine("Enter 1 to Buy 2 to sell");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of share ");
                int a = int.Parse(Console.ReadLine());
                int b = a;
                if (choice == 1)
                {
                    nus.Add(b);
                    tt.Add("Buy");
                }
                else
                {
                    tt.Add("sell");
                    nus.Add(b);
                }
                Console.WriteLine("Enter the price per share");
                int c = int.Parse(Console.ReadLine());
                sp.Add(c);
                arramt[i] = (c * b);
                this.sa.shareName = sn;
                this.sa.sharePrice = sp;
                this.sa.numberofshare = nus;
                this.sa.shareamountindollar = arramt;
                this.sa.transactiontype = tt;
            }
            double totalvalue = 0;
            for (int i = 0; i < this.sa.numberofStocks; i++)
            {
                if (this.sa.transactiontype[i].ToString().Equals("Buy"))
                {
                    totalvalue += this.sa.shareamountindollar[i];
                }
                else
                {
                    totalvalue -= this.sa.shareamountindollar[i];
                }
            }
            this.sa.valueof = totalvalue;
        }

        /// <summary>
        ///to Print the report.
        /// </summary>
        /// <param name="custname">The custname.</param>
        public void PrintReport(string custname)
        {
            if (this.sa.customerName.Equals(custname))
            {
                Console.WriteLine("customer name " + this.sa.customerName.ToString());
                Console.WriteLine("Transation Time " + this.sa.transactiontime.ToString());
                Console.WriteLine("Total number of stocks " + this.sa.numberofStocks.ToString());
                Console.WriteLine("Total value of Stock: " + string.Format((this.sa.valueof).ToString()));
                for (int i = 0; i < sa.numberofStocks; i++)
                {
                    Console.WriteLine("Share Name: " + this.sa.shareName[i]);
                    Console.WriteLine("Number of Share: " + this.sa.numberofshare[i]);
                    Console.WriteLine("Price of Share: " + sa.sharePrice[i]);
                    Console.WriteLine("amount of Share in dollar: " + sa.shareamountindollar[i]);
                    Console.WriteLine("Transaction Type : " + sa.transactiontype[i]);
                }
            }
        }
    }
}