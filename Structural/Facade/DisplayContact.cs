// -------------------------------------------------------------------------------------------------------
// <copyright file="DisplayContact.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// class to display contacts
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Facade.IAddressBook" />
    public class DisplayContact : IAddressBook
    {
        /// <summary>
        /// Does the operation of displaying
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        public void DoOperation(string filepath)
        {
            string contactjson = File.ReadAllText(filepath);
            List<Contact> cj = (List<Contact>)JsonConvert.DeserializeObject<List<Contact>>(contactjson);
            foreach (Contact co in cj)
            {
                Console.WriteLine(co);
                Console.WriteLine();
            }
        }
    }
}