// -------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookFacadeClass.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Facade class of AddressBook
    /// </summary>
    public class AddressBookFacadeClass
    {
        private AddContact addContact;
        private DeleteContact deleteContact;
        private EditContact editContact;
        private DisplayContact displayContact;

        /// <summary>
        /// Initializes a new instance of this class <see cref="AddressBookFacadeClass"/> class.
        /// </summary>
        public AddressBookFacadeClass()
        {
            this.addContact = new AddContact();
            this.deleteContact = new DeleteContact();
            this.editContact = new EditContact();
            this.displayContact = new DisplayContact();
        }

        /// <summary>
        /// calls add contact class
        /// </summary>
        /// <param name="file">The file.</param>
        public void DoAddContact(string file)
        {
            this.addContact.DoOperation(file);
        }

        /// <summary>
        /// calls the editcontact class method
        /// </summary>
        /// <param name="file">The file.</param>
        public void DoEditContact(string file)
        {
            this.editContact.DoOperation(file);
        }

        /// <summary>
        /// calls the delete contact class's  method 
        /// </summary>
        /// <param name="file">The file.</param>
        public void DoDeleteContact(string file)
        {
            this.deleteContact.DoOperation(file);
        }

        /// <summary>
        ///  calls the display contact class's  method 
        /// </summary>
        /// <param name="file">The file.</param>
        public void DoDisplayContact(string file)
        {
            this.displayContact.DoOperation(file);
        }
    }
}