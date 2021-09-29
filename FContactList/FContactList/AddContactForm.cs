namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal partial class AddContactForm : Form
    {
        private ContactList cl;
        public AddContactForm(ContactList cL)
        {
            cl = cL;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person newPerson = new();
            if (String.IsNullOrWhiteSpace(nameBox.Text))
                MessageBox.Show("Måste minst ange ett förnamn för att skapa en ny kontakt");
            else
            {
                newPerson.Name = nameBox.Text;
                newPerson.LastName = LastNameBox.Text;
                newPerson.Alias = aliasBox.Text;
                newPerson.Email = mailBox.Text;
                newPerson.LinkedIn = linkedinBox.Text;
                newPerson.Twitter = twitterBox.Text;
                newPerson.BirthDate = dateTimePicker1.Value;
                cl.AddContact(newPerson);
                this.Close();
            }

        }
    }
}
