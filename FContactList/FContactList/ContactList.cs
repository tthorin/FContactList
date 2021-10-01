namespace FContactList
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class ContactList
    {
        public List<Person> Contacts { get; set; }
        public string Path { get; set; } = "Contacts";
        public string FileName { get; set; } = "contactlist";

        public ContactList()
        {
            Contacts = LoadList();
        }

        public ContactList(string path = "Contacts", string fileName = "contactlist")
        {
            Path = path;
            FileName = fileName;
            Contacts = LoadList();
        }

        public List<Person> LoadList()
        {
            string fileName = FileName + ".json";
            List<Person> loadResult;
            if (Directory.Exists(Path) && File.Exists($@"{Path}\{fileName}"))
            {
                string json = File.ReadAllText($@"{Path}\{fileName}");
                loadResult = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else loadResult = new List<Person>();
            return loadResult;
        }

        private void SaveList()
        {
            string directory = "Contacts";
            string fileName = "contactlist.json";
            var file = JsonConvert.SerializeObject(Contacts, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
            File.WriteAllText($@"{directory}\{fileName}", file);
        }

        public List<string> BDaysThisMonth()
        {
            List<string> thisMonthsBdays = new();
            foreach (var contact in Contacts)
            {
                int age = contact.Age + 1;
                if (DateTime.Now.Month == contact.BirthDate.Month)
                {
                    thisMonthsBdays.Add($"{contact.FullName} fyller {age} den {contact.BirthDate.Day} {contact.BirthDate.Month}.");
                }
            }
            return thisMonthsBdays;
        }

        public void AddContact(Person newContact)
        {
            if (!String.IsNullOrWhiteSpace(newContact.Name) && newContact.Name.Length > 2)
                newContact.Name = newContact.Name.Substring(0, 1).ToUpper() + newContact.Name.Substring(1).ToLower();
            if (!String.IsNullOrWhiteSpace(newContact.LastName) && newContact.LastName.Length > 2)
                newContact.LastName = newContact.LastName.Substring(0, 1).ToUpper() + newContact.LastName.Substring(1).ToLower();

            Contacts.Add(newContact);
            SaveList();
        }
    }
}