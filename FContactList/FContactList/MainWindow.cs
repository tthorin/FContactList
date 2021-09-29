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
        internal ContactList CL = new();
        public MainWindow()
        {
            InitializeComponent();

            dataGridView1.DataSource = CL.Contacts;
            
            
            if (CL.Contacts.Find(x => x.Name == "Bettan") is not Person) CL.AddContact(new Person() { Name = "Bettan", LastName = "Lund" });
            List<string> fullNameList = new();
            foreach (var person in CL.Contacts)
            {
                nameListBox.Items.Add(person.Name + " " + person.LastName);
            }
            

        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            AddContactForm acf = new AddContactForm(CL);
            acf.ShowDialog();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            foreach (var person in CL.Contacts)
            {
                nameListBox.Items.Add(person.Name + " " + person.LastName);
            }
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CL.Contacts.Count >= nameListBox.SelectedIndex)
            {
                textBox1.Text = CL.Contacts[nameListBox.SelectedIndex].BirthDate.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
