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
            if(jsonstr.Length!=0)
            {
                cont = (List<Contact>)JsonConvert.DeserializeObject<List<Contact>>(jsonstr);
            }
            else
            {
                cont = new List<Contact>();
            }

        }
        

    }
}
