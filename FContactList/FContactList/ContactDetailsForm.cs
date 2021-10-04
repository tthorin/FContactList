// -----------------------------------------------------------------------------------------------
//  AddContactForm.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

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
    using static System.Net.Mime.MediaTypeNames;

    internal partial class ContactDetailsForm : Form
    {
        private ContactList cl;
        private Person person;

        public ContactDetailsForm(ContactList cL)
        {
            cl = cL;
            person = new();
            InitializeComponent();
            //nameBox.DataBindings.Add("Text", testP, "Name", false, DataSourceUpdateMode.OnPropertyChanged); //<<<=====TODO: DO THIS all over the place
            
        }
        public void EditPerson(Person person)
        {
            this.person = person;
            SetDataBindings();
            this.Show();
        }
        private void SetDataBindings()
        {
            nameBox.DataBindings.Add("Text", person, "Name", false, DataSourceUpdateMode.OnPropertyChanged); //<<<=====TODO: DO THIS all over the place
            LastNameBox.DataBindings.Add("Text", person, "LastName", false, DataSourceUpdateMode.OnPropertyChanged);
            aliasBox.DataBindings.Add("Text", person, "Alias", false, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Value", person, "BirthDate", false, DataSourceUpdateMode.OnPropertyChanged);
            mailBox.DataBindings.Add("Text", person, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            linkedinBox.DataBindings.Add("Text", person, "LinkedIn", false, DataSourceUpdateMode.OnPropertyChanged);
            facebookBox.DataBindings.Add("Text", person, "Facebook", false, DataSourceUpdateMode.OnPropertyChanged);
            instagramBox.DataBindings.Add("Text", person, "Instagram", false, DataSourceUpdateMode.OnPropertyChanged);
            twitterBox.DataBindings.Add("Text", person, "Twitter", false, DataSourceUpdateMode.OnPropertyChanged);
            githubBox.DataBindings.Add("Text", person, "GitHub", false, DataSourceUpdateMode.OnPropertyChanged);
            bestFoodBox.DataBindings.Add("Text", person, "BestFood", false, DataSourceUpdateMode.OnPropertyChanged);
            worstFoodBox.DataBindings.Add("Text", person, "WorstFood", false, DataSourceUpdateMode.OnPropertyChanged);
            favAnimalBox.DataBindings.Add("Text", person, "FavouriteAnimal", false, DataSourceUpdateMode.OnPropertyChanged);
            favMovieGenreBox.DataBindings.Add("Text", person, "FavouriteMovieGenre", false, DataSourceUpdateMode.OnPropertyChanged);
            notesBox.DataBindings.Add("Text", person, "Notes", false, DataSourceUpdateMode.OnPropertyChanged);
            ghostedcheckBox.DataBindings.Add("Checked", person, "IsGhosted", false, DataSourceUpdateMode.OnPropertyChanged);
            blockedCheckBox.DataBindings.Add("Checked", person, "IsBlocked", false, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Person newPerson = new();
            //if (String.IsNullOrWhiteSpace(nameBox.Text))
            //    MessageBox.Show("Måste ange ett förnamn för att skapa en ny kontakt");
            //else
            //{
            //    newPerson.Name = nameBox.Text;
            //    newPerson.LastName = LastNameBox.Text;
            //    newPerson.Alias = aliasBox.Text;
            //    newPerson.Email = mailBox.Text;
            //    newPerson.LinkedIn = linkedinBox.Text;
            //    newPerson.Twitter = twitterBox.Text;
            //    newPerson.BirthDate = dateTimePicker1.Value;
            //    cl.AddContact(newPerson);
            //    this.Close();
            //}

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
