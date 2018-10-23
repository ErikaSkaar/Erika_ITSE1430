
/*Student:Erika Ballering
 * Teacher: Michael Taylor
 * Class: ITSE 1430"Intro to C#" 
 * Program:Character Creator*/

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
            var form = new AboutDesign();
            if (form.ShowDialog(this) == DialogResult.Cancel) return;
        }

        private void OnExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to exit?", "End of the Road...", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void OnCharacterNew(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Character);
           RefreshCharacters();
        }

        private Character GetSelectedCharacter()
        {
            return _listCharacters.SelectedItem as Character;
        }

        private void RefreshCharacters()
        {
            var characters = _database.GetAll();

            _listCharacters.Items.Clear();
            _listCharacters.Items.AddRange(characters);
        }

        private void OnCharacterEdit(object sender, EventArgs e)
        {
            EditCharacter();
        }
        private void EditCharacter()
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            var form = new CharacterForm();
            form.Text = "Edit Character";
            form.Character = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Character);
            RefreshCharacters();
        }
        private void OnCharacterDoubleClick(object sender, EventArgs e)
        {
            EditCharacter();
        }
                //not working on double click

        private void OnCharacterDelete(object sender, EventArgs e)
        {
            DeleteCharacter();
        }
        private void DeleteCharacter()
        {
            if (MessageBox.Show( "Are you sure you want to delete this character?",  "Finish them...", MessageBoxButtons.YesNo) == DialogResult.No) 
                return;
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            _database.Remove(item.Name);
            RefreshCharacters();
        }
        private void OnListKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteCharacter();
            };
        }

        private CharacterDatabase _database = new CharacterDatabase();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listCharacters.DisplayMember = "Name";
            RefreshCharacters();
        }

       private void MainForm_Load(object sender, EventArgs e)
        {
                //cannnot get rid of this or compiler screams
        }
    }
}
