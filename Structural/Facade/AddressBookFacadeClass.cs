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
    }
}
