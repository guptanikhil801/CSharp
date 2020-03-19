// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;

    /// <summary>
    /// program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice : ");
            Console.WriteLine("1-Commercial Data      2-Deck Of Card      3- Deck Of Card using queue     4-Inventory Data");
            Console.WriteLine("5-Inventory Management              6-Stock         7-Address Book");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CommercialData.Management cm = new CommercialData.Management();
                    cm.DriverMethod();
                    break;
                case 2:
                    DeckOfCards.CardRunner.DisplayCardin2D();
                    break;
                case 3:
                    DeckOfCardQueue.CardsInQueue.DriverMethodsCardsQueue();
                    break;
                case 4:
                    InventoryData.InventoryMain.DriverInventory();
                    break;
                case 5:
                    InventoryManagement.InventoryManagement.DriverInventoryManagement();
                    break;
                case 6:
                    Stock.StockPortfolio.Driverstportfolio();
                    break;
            }
        }
    }
}