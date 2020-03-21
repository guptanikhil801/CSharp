namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class AddressBookFacadeClass
    {
        private AddContact addContact;
        private DeleteContact deleteContact;
        private EditContact editContact;
        private DisplayContact displayContact;
        public AddressBookFacadeClass()
        {
            addContact = new AddContact();
            deleteContact = new DeleteContact();
            editContact = new EditContact();
            displayContact = new DisplayContact();
        }
        public void DoAddContact(string file)
        {
            addContact.DoOperation(file);
        }
        public void DoEditContact(string file)
        {
            editContact.DoOperation(file);
        }
        public void DoDeleteContact(string file)
        {
            deleteContact.DoOperation(file);
        }
        public void DoDisplayContact(string file)
        {
            displayContact.DoOperation(file);
        }
    }
}
