// -------------------------------------------------------------------------------------------------------
// <copyright file="FacadeTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to test facade design pattern
    /// </summary>
    public class FacadeTest
    {
        /// <summary>
        /// driver method.
        /// </summary>
        public static void FacadeDriverMethod()
        {
            AddressBookFacadeClass facade = new AddressBookFacadeClass();
            Console.WriteLine("Enter File Path");
            string filepath = Console.ReadLine();
            Console.WriteLine("Enter you choice 1: Add Contact      2:  Edit Contact    3:  Delete contact    4:   Display Contact");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: facade.DoAddContact(filepath);
                    break;
                case 2:
                    facade.DoEditContact(filepath);
                    break;
                case 3:
                    facade.DoDeleteContact(filepath);
                    break;
                case 4: facade.DoDisplayContact(filepath);
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
