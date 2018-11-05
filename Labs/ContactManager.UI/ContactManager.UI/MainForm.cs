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

        private void OnExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to exit?", "Exit Contact Manager", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            var form = new AboutForm();
            if (form.ShowDialog(this) == DialogResult.Cancel) return;
        }

        //will need to refresh contacts 
        private void OnNewContact(object sender, EventArgs e)
        {
            var form = new ContactInformation();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Contact);

        }

        private void OnEditContact(object sender, EventArgs e)
        {

        }

        private void OnDeleteContact(object sender, EventArgs e)
        {

        }

        private ContactDatabase _database = new ContactDatabase();
    }
}
