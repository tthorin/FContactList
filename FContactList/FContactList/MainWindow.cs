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
        BindingList<Person> contactBindingList;
        BindingSource contactBindSource;

        //internal ContactList CL = new();
        public MainWindow()
        {
            InitializeComponent();
            contactBindingList = new BindingList<Person>(CL.Contacts);
            contactBindSource = new BindingSource();
            contactBindSource.DataSource = contactBindingList;


            //var source = new BindingSource(testList, null);
            nameListBox.DataSource = contactBindSource;


            nameListBox.DisplayMember = "FullName";
            firstNameCombo.DataSource = contactBindSource;
            firstNameCombo.DisplayMember = "Name";
            lastNameCombo.DataSource = contactBindSource;
            lastNameCombo.DisplayMember = "lastName";



        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            ContactDetailsForm acf = new ContactDetailsForm(CL);
            acf.Show();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {

            //nameListBox.Items.Clear();
            //foreach (var person in CL.Contacts)
            //{
            //    nameListBox.Items.Add(person.Name + " " + person.LastName);
            //}
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (nameListBox.SelectedIndex >= 0 && contactBindSource.Count >= nameListBox.SelectedIndex)
            {   
                textBox1.Text = contactBindSource[nameListBox.SelectedIndex].ToString().Replace("|", "\r\n");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void nameListBox_DoubleClick(object sender, EventArgs e)
        {
            ContactDetailsForm editForm = new ContactDetailsForm(CL);
            editForm.EditPerson((Person)contactBindSource[nameListBox.SelectedIndex]);
        }
    }
}
