// -------------------------------------------------------------------------------------------------------
// <copyright file="DeleteContact.cs" company="Bridgelabz">
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
    /// class to create delete contact
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Facade.IAddressBook" />
    public class DeleteContact : IAddressBook
    {
        /// <summary>
        /// Does the operation of deleting contact
        /// </summary>
        /// <param name="filepath">The file path.</param>
        public void DoOperation(string filepath)
        {
            Console.WriteLine("Enter First name");
            string first = Console.ReadLine();
            string jsoncont = File.ReadAllText(filepath);
            List<Contact> ctlist;
            ctlist = (List<Contact>)JsonConvert.DeserializeObject<List<Contact>>(jsoncont);
            foreach (Contact co in ctlist)
            {
                if (co.FirstName.Equals(first))
                {
                    ctlist.Remove(co);
                    break;
                }
            }

            string contactlist = JsonConvert.SerializeObject(ctlist, Formatting.Indented);
            File.WriteAllText(filepath, contactlist);
            Console.WriteLine("Contact deleted successfully");
        }
    }
}
