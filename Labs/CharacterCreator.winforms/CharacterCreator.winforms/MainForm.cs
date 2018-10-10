using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Character Creator", "About", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "End of the Road...", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void OnCharacterAdd(object sender, EventArgs e)
        {

        }
    }
}
