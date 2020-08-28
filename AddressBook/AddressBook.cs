// This File creates an address book

using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {

        // Creating a dictionary full of contacts keyvalue pairs
        public Dictionary<string, Contact> ContactList { get; set; }

        // creating an address book using the contact list
        // constructor
        public AddressBook()
        {
            ContactList = new Dictionary<string, Contact>();
        }
        // Method that accepts a contact and adds it to the contact list
        public void AddContact(Contact newContact)
        {
            ContactList.Add(newContact.Email, newContact);
        }
        //Grabbing by email
        public Contact GetByEmail(string email)
        {
            return ContactList[email];
        }
    }

}