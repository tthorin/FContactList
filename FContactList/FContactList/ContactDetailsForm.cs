﻿// -----------------------------------------------------------------------------------------------
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
        private MainWindow mw;
        private Person person;
        private bool addingPerson = false;
        private int index;

        public ContactDetailsForm(MainWindow main, int idx = 0)
        {
            index = idx;
            mw = main;
            //person = new();
            InitializeComponent();
            mw.contactBindingList.AllowEdit = false;
        }
        public void AddPerson()
        {
            addingPerson = true;
            SetupForm();
            this.Show();
        }
        public void EditPerson(Person person)
        {
            this.person = (Person)mw.contactBindingList[index].Clone();
            SetupForm();
            this.Show();
        }
        public void ShowPerson(Person person)
        {
            this.person = person;
            SetUpAsViewWindow();
            this.Show();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (addingPerson) mw.contactBindingList.Add(person);
            if (!addingPerson) mw.contactBindingList[index] = person;
            mw.CL.Contacts = mw.contactBindingList.ToList();
            mw.CL.Contacts.Sort(Person.CompareByFullName);
            mw.CL.Save();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Stänga utan att spara?", "Stänga fönster", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            VerifySaveButton();
        }
        private void SetupForm()
        {
            SetDataBindings();
            VerifySaveButton();
        }
        private void VerifySaveButton()
        {
            if (nameBox.Text is null || nameBox.Text.Length < 2)
            {
                saveButton.Enabled = false;
                tooShortNameLabel.Visible = true;
            }
            else
            {
                saveButton.Enabled = true;
                tooShortNameLabel.Visible = false;
            }
        }
        private void SetDataBindings()
        {
            nameBox.DataBindings.Add("Text", person, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
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
        private void SetUpAsViewWindow()
        {
            SetDataBindings();
            VerifySaveButton();
            nameBox.ReadOnly = true;
            LastNameBox.ReadOnly = true;
            aliasBox.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            mailBox.ReadOnly = true;
            linkedinBox.ReadOnly = true;
            facebookBox.ReadOnly = true;
            instagramBox.ReadOnly = true;
            twitterBox.ReadOnly = true;
            githubBox.ReadOnly = true;
            bestFoodBox.ReadOnly = true;
            worstFoodBox.ReadOnly = true;
            favAnimalBox.ReadOnly = true;
            favMovieGenreBox.ReadOnly = true;
        }

        private void ContactDetailsForm_Load(object sender, EventArgs e)
        {
            VerifySaveButton();
        }
    }
}
