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

            if (!ValidateChildren())
                return;

            var contact = new Contact()
            {
                Name = _txtName.Text,
                Email = _txtEmailAddress.Text,
            };

            //var results = ObjectValidator.Validate(contact);                <---- No longer likes ObjectValidator

            //foreach (var result in results)
            //{
            //    MessageBox.Show(this, result.ErrorMessage, "Validation Failed", MessageBoxButtons.OK);
            //    return;
            //};

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        //Validate on load
        private void ContactForm_Load(object sender, EventArgs e)
        {
            if(Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.Email;
            };

            ValidateChildren();
        }
    }
}
