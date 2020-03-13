// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookFactory.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this class has all method to add, delete and edit
    /// </summary>
    public class AddressBookFactory
    {
        /// <summary>
        /// it adds contact to contact list
        /// </summary>
        /// <param name="filepath"> path of file</param>
        public void Add(string filepath)
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

        /// <summary>
        /// to delete a contact from contact list
        /// </summary>
        /// <param name="filepath">path of file</param>
        public void Delete(string filepath)
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

        /// <summary>
        /// it modifies the data according to user
        /// </summary>
        /// <param name="filepath">path of file</param>
        public void Edit(string filepath)
        {
            string jsoncontact = File.ReadAllText(filepath);
            List<Contact> cl = (List<Contact>)JsonConvert.DeserializeObject<List<Contact>>(jsoncontact);
            Console.WriteLine("Available contacts(first name)");
            foreach (Contact co in cl)
            {
                Console.Write(co.FirstName + "      ");
            }
            Console.WriteLine("which one you want to Edit enter First Name(case sensitive)");
            string first = Console.ReadLine();
            Console.WriteLine("which field you want to edit enter choice (case sensitive)");
            Console.WriteLine(" L:    Last Name,   P:    Phone Number,    A:   Address,   C:     City,    S:    State,    Z:     Zip");
            char choice = char.Parse(Console.ReadLine());
            foreach (Contact co in cl)
            {
                if (co.FirstName.Equals(first))
                {
                    Console.WriteLine("Enter New detail");
                    string newdetail = Console.ReadLine();
                    switch (choice)
                    {
                        case 'L':
                            co.LastName = newdetail;
                            break;
                        case 'P':
                            co.PhoneNumber = newdetail;
                            break;
                        case 'A':
                            co.Address = newdetail;
                            break;
                        case 'C':
                            co.City = newdetail;
                            break;
                        case 'S':
                            co.State = newdetail;
                            break;
                        case 'Z':
                            co.Zip = newdetail;
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
            }
            Console.WriteLine("contact edited successfully");
            string editedjson = JsonConvert.SerializeObject(cl, Formatting.Indented);
            File.WriteAllText(filepath, editedjson);
        }

        /// <summary>
        /// it displays all the contact in console
        /// </summary>
        /// <param name="filepath">path of file</param>
        public void DisplayContact(string filepath)
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

    /// <summary>
    /// it has code for details
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets zip
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// to override object to string
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return string.Format("FirtsName:   {0}\nlastName:    {1}\n" +
                "phoneNumber: {2}\ncity:        {3}\nstate:       {4}\nzip:         {5}\naddress:     {6}"
                , FirstName, LastName, PhoneNumber, City, State, Zip, Address);
        }
    }
}
