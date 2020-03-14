namespace OopsPrograms.Stock
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to create object of type stock
    /// </summary>
    public class Stock
    {
        public string ShareName { get; set; }
        public int Numberofshare { get; set; }
        public double SharePrice { get; set; }
        public double Stockvalue { get; set; }
        public override string ToString()
        {
            return string.Format("Stockname:\t{0}\nNumber of share:\t{1}\nSharePrice:\t{2}\nTotal stock price:\t{3}", this.ShareName, this.Numberofshare, this.SharePrice, this.Stockvalue);
        }
    }

    /// <summary>
    /// class to create list of stock
    /// </summary>
    public class Portfolio
    {
        public List<Stock> Portfoliodata;
        public double Portfoliovalue { get; set; }

    }
}
