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
        
        //internal ContactList CL = new();
        public MainWindow()
        {
            InitializeComponent();
            
            
            //BindingList<Person> testList = new BindingList<Person>(CL.Contacts);
            //var source = new BindingSource(testList, null);
            nameListBox.DataSource = CL.Contacts;
            nameListBox.DisplayMember = "FullName";
            comboBox1.DataSource = CL.Contacts;
            comboBox1.DisplayMember = "FullName";
            

        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            AddContactForm acf = new AddContactForm(CL);
            acf.ShowDialog();
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
            if (CL.Contacts.Count >= nameListBox.SelectedIndex)
            {
                textBox1.Text = CL.Contacts[nameListBox.SelectedIndex].ToString().Replace("|", "\r\n");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameListBox.Focus();
        }
    }
}
