namespace DesignPattern.Structural.Facade
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    public class DeleteContact : IAddressBook
    {
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
