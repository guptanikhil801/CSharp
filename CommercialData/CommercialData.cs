namespace OopsPrograms.CommercialData
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CommercialData
    {
        public void TakeData(string customername)
        {
            StockAccount sa = new StockAccount();
            sa.customerName = customername;
            Console.WriteLine("In How many company's stock u want to do transaction");
            sa.numberofStocks = int.Parse(Console.ReadLine());
            sa.shareName = new List<string>();
            sa.sharePrice = new List<int>();
            sa.shareamount = new List<int>();


        }
    }
}
