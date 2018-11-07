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
        
        //Cancel Message 
        private void OnCancel(object sender, EventArgs e)
        {
                DialogResult = DialogResult.Cancel;
                Close();
        }
        
        //Send Message
        private void OnSend(object sender, EventArgs e)
        {

        }
    }
}
