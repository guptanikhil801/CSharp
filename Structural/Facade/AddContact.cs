// -------------------------------------------------------------------------------------------------------
// <copyright file="AddContact.cs" company="Bridgelabz">
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
    /// class to add contact
    /// </summary>
    /// <seealso cref="DesignPattern.Structural.Facade.IAddressBook" />
    public class AddContact : IAddressBook
    {
        /// <summary>
        /// Does the operation.
        /// </summary>
        /// <param name="filepath">The path of file.</param>
        public void DoOperation(string filepath)
        {
            string jsonstr = File.ReadAllText(filepath);
            List<Contact> cont;
            if (jsonstr.Length != 0)
            {
                cont = (List<Contact>)JsonConvert.DeserializeObject<List<Contact>>(jsonstr);
            }
            else
            {
                cont = new List<Contact>();
            }

            Contact ct = new Contact();
            Console.WriteLine("Enter your first Name");
            ct.FirstName = Console.ReadLine();
            foreach (Contact c in cont)
            {
                if (c.FirstName.Equals(ct.FirstName))
                {
                    Console.WriteLine("This contact already exist...Enter with some difference or a new one");
                    return;
                }
            }

            Console.WriteLine("Enter your Last Name");
            ct.LastName = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            ct.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Address");
            ct.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            ct.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            ct.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            ct.Zip = Console.ReadLine();
            cont.Add(ct);
            Console.WriteLine("Contact Successfully added");
            string jsoncontact = JsonConvert.SerializeObject(cont, Formatting.Indented);
            File.WriteAllText(filepath, jsoncontact);
        }
    }
}