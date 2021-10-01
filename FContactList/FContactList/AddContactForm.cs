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
        private Person testP = new(); //TODO: Clean up
        
        public AddContactForm(ContactList cL)
        {
            cl = cL;

            testP = cl.Contacts[0]; //TODO: Clean up

            InitializeComponent();

            var bindlist = new BindingList<Person>(cl.Contacts); //TODO: Clean up?
            var source = new BindingSource(bindlist, null);//TODO: Clean up?
            dataGridView1.DataSource = source;//TODO: Clean up?
            nameBox.DataBindings.Add("Text", testP, "Name", false, DataSourceUpdateMode.OnPropertyChanged); //<<<=====TODO: DO THIS all over the place
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person newPerson = new();
            if (String.IsNullOrWhiteSpace(nameBox.Text))
                MessageBox.Show("Måste ange ett förnamn för att skapa en ny kontakt");
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Förlora all inmatning och stäng fönstret.", "Stäng Fönster", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
