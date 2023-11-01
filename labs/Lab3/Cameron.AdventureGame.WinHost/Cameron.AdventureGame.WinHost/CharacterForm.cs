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
        public CharacterForm ( List<Character> CharacterList)
        {
            InitializeComponent();
            Character= new Character();
            _characterList = CharacterList;
            
        }

        public CharacterForm ()
        {
        }

        private int _freePoints;
        private List<Character> _characterList;
        public int FreePoints { get; set; }
        public Character Character { get; private set; }
       
        private void OnSave (object sender, EventArgs e)
        {
            var button= sender as Button;   
            
            Character.CharacterName = _CharacterNameTxtBox.Text;
            Character.SelectedRace= (Character.CharacterRace)_RaceComboBox.SelectedIndex;
            
            Character.SelectedClass=(Character.CharacterClass)_ClassComboBox.SelectedIndex;
            Character.SetClassStats();

            if (!Character.TryValidate(out var error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            _characterList.Add(Character);
            DialogResult = DialogResult.OK;
            Close();

        }
        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        

        
        private void OnRaceChoice ( object sender, EventArgs e )
        {
               Character.SelectedRace= (Character.CharacterRace)_ClassComboBox.SelectedIndex;

           
        }

        private void OnClassChoice ( object sender, EventArgs e )
        {
            var ComboBox= sender as ComboBox;
            Character.SelectedClass=(Character.CharacterClass)_RaceComboBox.SelectedIndex;
            Character.SetClassStats();
            DisplayStats();
           
        }
        private void DisplayStats ()
        {
            if (Character != null)
            {
                _StrengthUpDown.Text= Character.Strength.ToString();
                _AgilityUpDown.Text= Character.Agility.ToString();
                _IntellectUpDown.Text=Character.Intelligence.ToString();
                _CharismaUpDown.Text= Character.Charisma.ToString();
                _DefenseUpDown.Text= Character.Defense.ToString();
                _ConstUpDown.Text= Character.Constitution.ToString();
            }
        }

        private void CharacterForm_Load ( object sender, EventArgs e )
        {
           
            Character character= new Character();
          _RaceComboBox.DataSource=Enum.GetValues(typeof(Character.CharacterRace));
            _ClassComboBox.DataSource=Enum.GetValues(typeof(Character.CharacterClass));

            AffixDataSource();
        
        }

        private void AffixDataSource () {
            
            DisplayStats();
        }

        private void AvailableValidation ()
        {
            FreePointLabel.Text=Character.FreeStatusPoints.ToString();

        }

        private void _AgilityUpDown_ValueChanged ( object sender, EventArgs e )
        {
            Character.Agility = (int)_AgilityUpDown.Value;
            AvailableValidation();
        }

        private void _IntellectUpDown_ValueChanged ( object sender, EventArgs e )
        {
            Character.Intelligence = (int)_IntellectUpDown.Value;
            AvailableValidation();
        }

        private void _CharismaUpDown_ValueChanged ( object sender, EventArgs e )
        {
            Character.Charisma = (int)_CharismaUpDown.Value;
            AvailableValidation();
        }

        private void _DefenseUpDown_ValueChanged ( object sender, EventArgs e )
        {
            Character.Defense= (int)_DefenseUpDown.Value;
            AvailableValidation();
        }

        private void _ConstUpDown_ValueChanged ( object sender, EventArgs e )
        {
            Character.Constitution= (int)_ConstUpDown.Value;
            AvailableValidation();
        }

        private void _StrengthUpDown_ValueChanged ( object sender, EventArgs e )
        {
            Character.Strength = (int)_StrengthUpDown.Value;
            AvailableValidation();
        }
    }
   //test of git
}
