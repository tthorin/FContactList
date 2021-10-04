// -----------------------------------------------------------------------------------------------
//  ContactList.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using static Helpers.ContactListIOHelpers;

    public class ContactList
    {
        public List<Person> Contacts { get; set; }
        private readonly string directory = "Contacts";
        private readonly string fileName = "contactlist";

        public ContactList()
        {
            Contacts = Load();
        }

        public ContactList(string dir = "Contacts", string fileName = "contactlist")
        {
            directory = dir;
            this.fileName = fileName;
            Contacts = Load();
        }

        public void Save()
        {
            string path = Path.Combine(directory, fileName + ".json");
            SaveList(Contacts, path);
        }
        private List<Person> Load()
        {
            string path = Path.Combine(directory, fileName + ".json");
            return LoadList(path);
        }

        public List<string> BDaysThisMonth()
        {
            List<string> thisMonthsBdays = new();
            foreach (Person contact in Contacts)
            {
                int age = contact.Age + 1;
                if (DateTime.Now.Month == contact.BirthDate.Month && !contact.IsBlocked)
                {
                    thisMonthsBdays.Add($"{contact.FullName} fyller {age} den {contact.BirthDate.Day} {contact.BirthDate.Month}.");
                }
            }
            return thisMonthsBdays;
        }

        public void AddContact(Person newContact)
        {
            if (!string.IsNullOrWhiteSpace(newContact.Name) && newContact.Name.Length > 2)
                newContact.Name = newContact.Name.Substring(0, 1).ToUpper() + newContact.Name.Substring(1).ToLower();
            if (!string.IsNullOrWhiteSpace(newContact.LastName) && newContact.LastName.Length > 2)
                newContact.LastName = newContact.LastName.Substring(0, 1).ToUpper() + newContact.LastName.Substring(1).ToLower();

            Contacts.Add(newContact);
            SaveList(Contacts, Path.Combine(directory, fileName + ".json"));
        }

        
    }
}