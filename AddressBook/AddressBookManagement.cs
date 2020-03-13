namespace OopsPrograms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class AddressBookManagement
    {
        public static void DriverAddressBook()
        {
            AddressBookFactory abf = new AddressBookFactory();
            Console.WriteLine("enter path");
            string path = Console.ReadLine();
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1:   Add,   2:    Delete,    3:     Edit,     4:    Display All Contact");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:abf.Add(path);
                    break;
                case 2:
                    abf.Delete(path);
                    break;
                case 3:
                    abf.Edit(path);
                    break;
                case 4:
                    abf.DisplayContact(path);
                    break;
                default: Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
