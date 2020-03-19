// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Management.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -----------------------------------------------------------------------------------------
namespace OopsPrograms.CommercialData
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CommercialData
    {
        StockAccount sa = new StockAccount();
        public void TakeData(string customername)
        {
            sa.customerName = customername;
            Console.WriteLine("In How many company's stock u want to do transaction");
            int numo = int.Parse(Console.ReadLine());
            sa.numberofStocks = numo;
            sa.transactiontime = DateTime.Now;
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
                sa.shareName = sn;
                sa.sharePrice = sp;
                sa.numberofshare = nus;
               sa.shareamountindollar = arramt;
                sa.transactiontype = tt;
            }
            double totalvalue = 0;
            for (int i = 0; i < sa.numberofStocks; i++)
            {
                if (sa.transactiontype[i].ToString().Equals("Buy"))
                {
                    totalvalue += sa.shareamountindollar[i];
                }
                else
                {
                    totalvalue -= sa.shareamountindollar[i];
                }
            }
            sa.valueof = totalvalue;
        }

        public void PrintReport(string custname)
        {
            if (sa.customerName.Equals(custname))
            {
                Console.WriteLine("customer name " + sa.customerName.ToString());
                Console.WriteLine("Transation Time " + sa.transactiontime.ToString());
                Console.WriteLine("Total number of stocks " + sa.numberofStocks.ToString());
                Console.WriteLine("Total value of Stock: " + string.Format((sa.valueof).ToString()));
                for (int i = 0; i < sa.numberofStocks; i++)
                {
                    Console.WriteLine("Share Name: " + sa.shareName[i]);
                    Console.WriteLine("Number of Share: " + sa.numberofshare[i]);
                    Console.WriteLine("Price of Share: " + sa.sharePrice[i]);
                    Console.WriteLine("amount of Share in dollar: " + sa.shareamountindollar[i]);
                    Console.WriteLine("Transaction Type : " + sa.transactiontype[i]);
                }
            }
        }
    }
}