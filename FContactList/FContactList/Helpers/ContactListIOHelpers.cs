// -----------------------------------------------------------------------------------------------
//  ContactListIOHelpers.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList.Helpers
{
    using FContactList.Extensions;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    public static class ContactListIOHelpers
    {
        public static List<Person> LoadList(string path)
        {
            DirectoryInfo dir = Directory.GetParent(path);
            List<Person> loadedList;
            string json = "";
            if (dir.Exists && File.Exists(path))
            {
                try
                {
                    json = File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte ladda kontaklistan.");
                    ex.LogThis();
                }
                loadedList = JsonToList(json);
            }
            else
            {
                loadedList = new List<Person>();
            }

            return loadedList;
        }

        private static List<Person> JsonToList(string json)
        {
            List<Person> listFromJson = new();
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    listFromJson = JsonConvert.DeserializeObject<List<Person>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte tolka kontaklistan.");
                    ex.LogThis();
                }
            }
            return listFromJson;
        }

        public static void SaveList(List<Person> contactList, string path)
        {
            string file = ListToJson(contactList);
            DirectoryInfo dir = Directory.GetParent(path);
            try
            {
                if (!dir.Exists) dir.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte skapa katalog för att spara kontaktlistan.");
                ex.LogThis();
            }
            try
            {
                File.WriteAllText(path, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte spara kontaktlistan.");
                ex.LogThis();
            }
        }

        private static string ListToJson(List<Person> contactList)
        {
            string json = "";
            try
            {
                json = JsonConvert.SerializeObject(contactList, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            }
            catch (Exception e)
            {
                e.LogThis();
                MessageBox.Show("Kunde inte omvandla till Json");
            }

            return json;
        }
    }
}
