namespace OopsPrograms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InventoryManagement
    {
        public static void DriverInventoryManagement()
        {
            Console.WriteLine("Enter file path");
            string filepath = Console.ReadLine();
            InventoryFactory ifi = new InventoryFactory();
            Console.WriteLine("enter your choice");
            Console.WriteLine("A:     Add,  D:     Delete      O:     output");
            char choice = char.Parse(Console.ReadLine());
            switch(choice) {
                case 'A':
                    ifi.Add(filepath);
                    break;
                case 'D':
                    ifi.Delete(filepath);
                    break;
                case 'O':
                    ifi.DisplayInventory(filepath);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
