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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        //Contact Class
        public Contact Contact { get; set; }

        //Cancel Add Contact
        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //Save Contact
        private void OnSave(object sender, EventArgs e)
        {
            var contact = new Contact()
            {
                Name = _txtName.Text,
                Email = _txtEmailAddress.Text,    
            };
            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
