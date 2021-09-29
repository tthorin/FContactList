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
            
            
            if (CL.Contacts.Find(x => x.Name == "Bettan") is not Person) CL.AddContact(new Person() { Name = "Bettan", LastName = "Lund" });
            List<string> fullNameList = new();
            foreach (var person in CL.Contacts)
            {
                listBox1.Items.Add(person.Name + " " + person.LastName);
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CL.Contacts.Count >= listBox1.SelectedIndex)
            {
                textBox1.Text = CL.Contacts[listBox1.SelectedIndex].BirthDate.ToString();
            }
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            AddContactForm acf = new AddContactForm(CL);
            acf.ShowDialog();
        }

        private void MainWindow_Enter(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var person in CL.Contacts)
            {
                listBox1.Items.Add(person.Name + " " + person.LastName);
            }

        }
    }
}
