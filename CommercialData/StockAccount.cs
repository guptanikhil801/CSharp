namespace OopsPrograms.CommercialData
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StockAccount
    {
        public string customerName { get; set; }
        public int numberofStocks { get; set; }
        public int MyProperty { get; set; }
        public List<string> shareName { get; set; }
        public List<int> numberofShare { get; set; }
        public List<int> sharePrice { get; set; }

        public DateTime transactiontime = DateTime.Now;
    }
}
