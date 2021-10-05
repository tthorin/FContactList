// -----------------------------------------------------------------------------------------------
//  MainWindow.cs by Thomas Thorin, Copyright (C) 2021.
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

    public partial class MainWindow : Form
    {
        public ContactList CL { get; set; } = new();
        public BindingList<Person> contactBindingList;
        

        //internal ContactList CL = new();
        public MainWindow()
        {
            InitializeComponent();
            contactBindingList = new BindingList<Person>(CL.Contacts);
            contactBindingList.ListChanged += ContactBindingList_ListChanged;
            contactBindingList.AllowEdit = false;
            
            
            contactBindSource.DataSource = contactBindingList;
            


            //var source = new BindingSource(testList, null);
            nameListBox.DataSource = contactBindSource;


            nameListBox.DisplayMember = "FullName";
            firstNameCombo.DataSource = contactBindSource;
            firstNameCombo.DisplayMember = "Name";
            lastNameCombo.DataSource = contactBindSource;
            lastNameCombo.DisplayMember = "lastName";
            textBox2.Lines = CL.BDaysThisMonth().ToArray();



        }

        private void ContactBindingList_ListChanged(object sender, ListChangedEventArgs e)
        {
            contactBindSource.ResetBindings(false);
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            ContactDetailsForm addForm = new(this, nameListBox.SelectedIndex);
            addForm.AddPerson();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {   
            //contactBindingList = new BindingList<Person>(CL.Contacts);
            //contactBindingList.ResetBindings();
            //contactBindSource.ResetBindings(false);
            //nameListBox.Refresh();
            textBox2.Clear();
            textBox2.Lines = CL.BDaysThisMonth().ToArray();
        }
        

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (nameListBox.SelectedIndex >= 0 && contactBindSource.Count >= nameListBox.SelectedIndex)
            {
                if (contactBindingList[nameListBox.SelectedIndex].IsGhosted) ghostPicture.Visible = true;
                else ghostPicture.Visible = false;
                if (contactBindingList[nameListBox.SelectedIndex].IsBlocked) blockedPicture.Visible = true;
                else blockedPicture.Visible = false;
                textBox1.Text = contactBindSource[nameListBox.SelectedIndex].ToString().Replace("|", "\r\n");
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

        private void contactBindSource_DataMemberChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hepp");
        }

        private void contactBindSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //MessageBox.Show("list changed");
        }
    }
}
