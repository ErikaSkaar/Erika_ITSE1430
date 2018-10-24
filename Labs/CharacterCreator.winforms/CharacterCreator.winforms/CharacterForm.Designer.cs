namespace CharacterCreator.winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtAttributesStrength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtAttributesIntelligence = new System.Windows.Forms.TextBox();
            this._txtAttributeAgility = new System.Windows.Forms.TextBox();
            this._txtAttributeConstitution = new System.Windows.Forms.TextBox();
            this._txtAttributeCharisma = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.strength = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.Charisma = new System.Windows.Forms.Label();
            this._cmbRaceBox = new System.Windows.Forms.ComboBox();
            this._cmbClassBox = new System.Windows.Forms.ComboBox();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name";
            // 
            // _txtName
            // 
            this._errors.SetError(this._txtName, "_txtName");
            this._txtName.Location = new System.Drawing.Point(149, 40);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(453, 20);
            this._txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attributes";
            // 
            // _txtAttributesStrength
            // 
            this._txtAttributesStrength.Location = new System.Drawing.Point(151, 196);
            this._txtAttributesStrength.Name = "_txtAttributesStrength";
            this._txtAttributesStrength.Size = new System.Drawing.Size(70, 20);
            this._txtAttributesStrength.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(149, 241);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(453, 150);
            this._txtDescription.TabIndex = 8;
            // 
            // _txtAttributesIntelligence
            // 
            this._txtAttributesIntelligence.Location = new System.Drawing.Point(241, 196);
            this._txtAttributesIntelligence.Name = "_txtAttributesIntelligence";
            this._txtAttributesIntelligence.Size = new System.Drawing.Size(70, 20);
            this._txtAttributesIntelligence.TabIndex = 4;
            // 
            // _txtAttributeAgility
            // 
            this._txtAttributeAgility.Location = new System.Drawing.Point(332, 196);
            this._txtAttributeAgility.Name = "_txtAttributeAgility";
            this._txtAttributeAgility.Size = new System.Drawing.Size(70, 20);
            this._txtAttributeAgility.TabIndex = 5;
            // 
            // _txtAttributeConstitution
            // 
            this._txtAttributeConstitution.Location = new System.Drawing.Point(425, 196);
            this._txtAttributeConstitution.Name = "_txtAttributeConstitution";
            this._txtAttributeConstitution.Size = new System.Drawing.Size(70, 20);
            this._txtAttributeConstitution.TabIndex = 6;
            // 
            // _txtAttributeCharisma
            // 
            this._txtAttributeCharisma.Location = new System.Drawing.Point(513, 196);
            this._txtAttributeCharisma.Name = "_txtAttributeCharisma";
            this._txtAttributeCharisma.Size = new System.Drawing.Size(70, 20);
            this._txtAttributeCharisma.TabIndex = 7;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(256, 413);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(374, 413);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 10;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(157, 175);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(47, 13);
            this.strength.TabIndex = 0;
            this.strength.Text = "Strength";
            // 
            // Intelligence
            // 
            this.Intelligence.AutoSize = true;
            this.Intelligence.Location = new System.Drawing.Point(239, 175);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(61, 13);
            this.Intelligence.TabIndex = 20;
            this.Intelligence.Text = "Intelligence";
            // 
            // Agility
            // 
            this.Agility.AutoSize = true;
            this.Agility.Location = new System.Drawing.Point(348, 175);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(34, 13);
            this.Agility.TabIndex = 21;
            this.Agility.Text = "Agility";
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(422, 175);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(62, 13);
            this.Constitution.TabIndex = 22;
            this.Constitution.Text = "Constitution";
            // 
            // Charisma
            // 
            this.Charisma.AutoSize = true;
            this.Charisma.Location = new System.Drawing.Point(520, 175);
            this.Charisma.Name = "Charisma";
            this.Charisma.Size = new System.Drawing.Size(50, 13);
            this.Charisma.TabIndex = 23;
            this.Charisma.Text = "Charisma";
            // 
            // _cmbRaceBox
            // 
            this._cmbRaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbRaceBox.FormattingEnabled = true;
            this._cmbRaceBox.Items.AddRange(new object[] {
            "Human",
            "Genasi",
            "Aasimar",
            "Dragon Born",
            "Minotaur"});
            this._cmbRaceBox.Location = new System.Drawing.Point(149, 87);
            this._cmbRaceBox.Name = "_cmbRaceBox";
            this._cmbRaceBox.Size = new System.Drawing.Size(115, 21);
            this._cmbRaceBox.TabIndex = 1;
            // 
            // _cmbClassBox
            // 
            this._cmbClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClassBox.FormattingEnabled = true;
            this._cmbClassBox.Items.AddRange(new object[] {
            "Barbarian",
            "Paladin",
            "Wizard",
            "Rogue",
            "Druid"});
            this._cmbClassBox.Location = new System.Drawing.Point(149, 124);
            this._cmbClassBox.Name = "_cmbClassBox";
            this._cmbClassBox.Size = new System.Drawing.Size(115, 21);
            this._cmbClassBox.TabIndex = 2;
            this._cmbClassBox.SelectedIndexChanged += new System.EventHandler(this.CharacterForm_Load);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(683, 448);
            this.ControlBox = false;
            this.Controls.Add(this._cmbClassBox);
            this.Controls.Add(this._cmbRaceBox);
            this.Controls.Add(this.Charisma);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.strength);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtAttributeCharisma);
            this.Controls.Add(this._txtAttributeConstitution);
            this.Controls.Add(this._txtAttributeAgility);
            this.Controls.Add(this._txtAttributesIntelligence);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtAttributesStrength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(699, 487);
            this.MinimumSize = new System.Drawing.Size(699, 487);
            this.Name = "CharacterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtAttributesStrength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtAttributesIntelligence;
        private System.Windows.Forms.TextBox _txtAttributeAgility;
        private System.Windows.Forms.TextBox _txtAttributeConstitution;
        private System.Windows.Forms.TextBox _txtAttributeCharisma;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label strength;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Charisma;
        private System.Windows.Forms.ComboBox _cmbRaceBox;
        private System.Windows.Forms.ComboBox _cmbClassBox;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}