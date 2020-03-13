namespace OopsPrograms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public override string ToString()
        {
            return string.Format("FirtsName:   {0}\nlastName:    {1}\n" +
                "phoneNumber: {2}\ncity:        {3}\nstate:       {4}\nzip:         {5}\naddress:     {6}"
                , FirstName, LastName, PhoneNumber, City, State, Zip, Address);
        }
    }

    public class AddressBookFactory
    {
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
        //public void Delete

    }
}
