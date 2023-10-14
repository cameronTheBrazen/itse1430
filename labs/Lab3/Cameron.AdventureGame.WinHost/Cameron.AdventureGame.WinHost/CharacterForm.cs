using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cameron.AdventureGame.WinHost
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent();
        }

        public Character Character { get; private set; }

        private void OnSave (object sender, EventArgs e)
        {
            var button= sender as Button;   
            var character=new Character();
            character.CharacterName = _CharacterNameTxtBox.Text;
            character.SelectedRace= (Character.CharacterRace)_ClassComboBox.SelectedIndex;
            
            character.SelectedClass=(Character.CharacterClass)_RaceComboBox.SelectedIndex;
            character.SetClassStats();

            if (!character.TryValidate(out var error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close();

        }
        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
