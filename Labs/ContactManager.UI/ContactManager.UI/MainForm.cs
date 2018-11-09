/*Student:Erika Ballering
 * Teacher: Michael Taylor
 * Class: ITSE 1430"Intro to C#" 
 * Program:Contact Manager*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listMainLeft.DisplayMember = "Name";
            _listMainRight.DisplayMember = "Message";

            RefreshContacts();
            RefreshMessages();
        }

        //Exit Program
        private void OnExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to exit?", "Exit Contact Manager", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        //About Message
        private void OnHelpAbout(object sender, EventArgs e)
        {
            var form = new AboutForm();
            if (form.ShowDialog(this) == DialogResult.Cancel) return;
        }

        //Start new Message form
        private void OnMessage(object sender, EventArgs e)
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new MessageForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _txtMsgContent.Send(form.Message);
        } //  MessageContent = _txtMsgContent

        //Adding New Contact
        private void OnNewContact(object sender, EventArgs e)
        {
            var form = new ContactForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Contact);
            RefreshContacts();
        }

        //Edit Contacts
        private void OnEditContact(object sender, EventArgs e)
        {
            EditContact();
        }

        //Edit from Database
        private void EditContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new ContactForm();
            form.Text = "Edit Contact";
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Contact);
            RefreshContacts();
        }

        //Delete Contacts
        private void OnDeleteContact(object sender, EventArgs e)
        {
            DeleteContact();
        }

        //Removes from Database
        private void DeleteContact()
        {
            if (MessageBox.Show("Are you sure you want to delete this contact?", "Contact Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var item = GetSelectedContact();
            if (item == null)
                return;

            _database.Remove(item.Name);
            RefreshContacts();
        }

        //Key delete of contact
        private void OnListKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteContact();
            };
        }

        //Selects Contact
        private Contact GetSelectedContact()
        {
            return _listMainLeft.SelectedItem as Contact;
        }

        //Refreshes Contacts
        private void RefreshContacts()
        {
            var contacts = _database.GetAll();

            _listMainLeft.Items.Clear();
            _listMainLeft.Items.AddRange(contacts);
        }

        //Refresh messages on right
        private void RefreshMessages()
        {
            var messages = from m in _sentMessages.GetAll()
                           select m;

            _listMainRight.Items.Clear();
            _listMainRight.Items.AddRange(messages.ToArray());
        }

        //Call from Database
        private IMessageServices _sentMessages = new MemoryMessageDatabase();
        private IContactDatabase _database = new MemoryContactDatabase();
    }
}
