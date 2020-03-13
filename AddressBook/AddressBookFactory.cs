namespace OopsPrograms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class Person
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
    }
}
