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
    public partial class CharacterForm : Form
    {

        public CharacterForm()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var character = new Character()
            {
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                AttributeStrength = GetInt32(_txtAttributesStrength),
                AttributeIntelligence = GetInt32(_txtAttributesIntelligence),
                AttributeAgility = GetInt32(_txtAttributeAgility),
                AttributeConstitution = GetInt32(_txtAttributeConstitution),
                AttributeCharisma = GetInt32(_txtAttributeCharisma),

            };
            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnValidateName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name input is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;
            if (Int32.TryParse(textBox.Text, out var value))
                return value;
            return -1;
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _txtDescription.Text = Character.Description;
                _cmbRaceBox.Text = Character.Race;
                _cmbClassBox.Text = Character.Class;
                _txtAttributesStrength.Text = Character.AttributeStrength.ToString();
                _txtAttributesIntelligence.Text = Character.AttributeIntelligence.ToString();
                _txtAttributeAgility.Text = Character.AttributeAgility.ToString();
                _txtAttributeConstitution.Text = Character.AttributeConstitution.ToString();
                _txtAttributeCharisma.Text = Character.AttributeCharisma.ToString();
            };

            ValidateChildren();
            /*not getting error icon to show 
             * unless type _txtName in Error on "_errors"
             and then it just stays on screen*/
        }
    }
}

