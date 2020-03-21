namespace DesignPattern.Structural.Facade
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    public class EditContact : IAddressBook
    {
        public void DoOperation(string filepath)
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
    }
}
