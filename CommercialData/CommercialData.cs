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
            sa.numberofStocks = int.Parse(Console.ReadLine());
            // sa.transactiontype
            sa.transactiontime = DateTime.Now;
            for (int i = 0; i < sa.numberofStocks; i++)
            {
                List<string> sn = new List<string>();//sa.shareName 
                List<int> sp = new List<int>(); //sa.sharePrice = 
                List<int> nus = new List<int>();// number of share
                List<int> sai = new List<int>(); // sa.shareamountindollar = 
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
                    sa.transactiontype.Add("sell");
                    nus.Add(b);
                }
                Console.WriteLine("Enter the price per share");
                int c = int.Parse(Console.ReadLine());
                sp.Add(c);
                sai.Add(c * b);
                sa.shareName = sn;
                sa.sharePrice = sp;
                sa.numberofshare = nus;
                sa.shareamountindollar = sai;
                sa.transactiontype = tt;

            }
            double totalvalue = 0;
            for (int i = 0; i <sa.numberofStocks; i++)
            {

                totalvalue += sa.shareamountindollar[i];
            }
            sa.valueof =  totalvalue;
        }

        public void PrintReport()
        {
            Console.WriteLine("customer name " + sa.customerName);
            Console.WriteLine("Transation Time " + sa.transactiontime);
            Console.WriteLine("Total number of stocks " + sa.transactiontime);
            Console.WriteLine("Total value of Stock: " + string.Format((sa.valueof).ToString()));
            for (int i = 1; i <= sa.numberofStocks; i++)
            {
                Console.WriteLine("Share Name: " + string.Format((sa.shareName).ToString()));
                Console.WriteLine("Number of Share: " + string.Format((sa.numberofshare).ToString()));
                Console.WriteLine("Price of Share: " + string.Format((sa.sharePrice).ToString()));
                Console.WriteLine("amount of Share in dollar: " + string.Format((sa.shareamountindollar).ToString()));
                Console.WriteLine("Transaction Type : " + string.Format((sa.sharePrice).ToString()));
            }
        }
    }
}
