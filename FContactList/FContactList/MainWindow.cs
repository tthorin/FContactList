// -----------------------------------------------------------------------------------------------
//  MainWindow.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class MainWindow : Form
    {
        public ContactList CL { get; set; } = new();

        private RefreshDisplay RefreshRadioSelectedInfo;

        public MainWindow()
        {
            InitializeComponent();
        }

        private delegate List<string> RefreshDisplay();

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            ContactDetailsForm addForm = new(this, nameListBox.SelectedIndex);
            addForm.AddPerson();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            UpdateDataSources();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (nameListBox.SelectedIndex >= 0 && CL.Contacts.Count >= nameListBox.SelectedIndex)
            {
                if (CL.Contacts[nameListBox.SelectedIndex].IsGhosted) ghostPicture.Visible = true;
                else ghostPicture.Visible = false;

                if (CL.Contacts[nameListBox.SelectedIndex].IsBlocked) blockedPicture.Visible = true;
                else blockedPicture.Visible = false;

                selectedPersonInfoDisplay.Text = CL.Contacts[nameListBox.SelectedIndex].ToString().Replace("|", "\r\n");
            }
        }

        private void nameListBox_DoubleClick(object sender, EventArgs e)
        {
            ContactDetailsForm showForm = new(this, nameListBox.SelectedIndex);
            showForm.ShowPerson((Person)nameListBox.SelectedItem);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ContactDetailsForm editForm = new ContactDetailsForm(this, nameListBox.SelectedIndex);
            editForm.EditPerson((Person)nameListBox.SelectedItem);
        }

        private void firstNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameListBox.Focus();
        }

        private void lastNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameListBox.Focus();
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            string fullName = CL.Contacts[nameListBox.SelectedIndex].FullName;
            int idx = nameListBox.SelectedIndex;
            DialogResult answer = MessageBox.Show($"Ta bort {fullName}.\r\nÄr du säker?", "Ta bort kontakt", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                CL.RemoveContact(idx);
                MessageBox.Show($"{fullName} borttagen.", "Kontakt borttagen.");
            }
        }

        private void bDayRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (bDayRadio.Checked)
            {
                RefreshRadioSelectedInfo = new RefreshDisplay(CL.BDaysThisMonth);
                radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
            }
        }

        private void ghostedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ghostedRadio.Checked)
            {
                RefreshRadioSelectedInfo = new RefreshDisplay(CL.GetAllGhosted);
                radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
            }
        }

        private void blockedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (blockedRadio.Checked)
            {
                RefreshRadioSelectedInfo = new RefreshDisplay(CL.GetAllBlocked);
                radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshRadioSelectedInfo = new RefreshDisplay(CL.BDaysThisMonth);
        }
        private void UpdateDataSources()
        {
            nameListBox.DataSource = null;
            nameListBox.DataSource = CL.Contacts;
            nameListBox.DisplayMember = "FullName";

            firstNameCombo.DataSource = null;
            firstNameCombo.DataSource = CL.Contacts;
            firstNameCombo.DisplayMember = "Name";

            lastNameCombo.DataSource = null;
            lastNameCombo.DataSource = CL.Contacts;
            lastNameCombo.DisplayMember = "lastName";


            radioSelectedInfoDisplayTextBox.Lines = RefreshRadioSelectedInfo().ToArray();
        }
    }
}
