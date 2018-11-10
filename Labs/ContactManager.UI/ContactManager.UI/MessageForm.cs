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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        //Contact Class
        public Contact Contact { get; set; }

        public Message Message { get; set; }

        //Cancel Message 
        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //Send Message
        private void OnSend(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(_txtMsgSubject.Text))
            {
                MessageBox.Show("Please enter on subject line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = new Message()
            {
                MessageName = _txtMsgName.Text,
                MessageEmailAddress = _txtMsgEmailAddress.Text,
                MessageSubject = _txtMsgSubject.Text,
                MessageContent = _txtMsgContent.Text,
            };

            Message = message;
            DialogResult = DialogResult.OK;

            Close();
        }

        //On form load validate name and email
        private void MessageForm_Load(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtMsgName.Text = Contact.Name;
                _txtMsgEmailAddress.Text = Contact.Email;
            }

            if (Message != null)
            {
                _txtMsgName.Text = Message.MessageName;
                _txtMsgEmailAddress.Text = Message.MessageEmailAddress;
            }

            ValidateChildren();
        }
    }
}