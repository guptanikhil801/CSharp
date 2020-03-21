namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    public class DisplayContact : IAddressBook
    {
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
