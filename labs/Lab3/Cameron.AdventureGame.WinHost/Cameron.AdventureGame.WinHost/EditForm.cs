using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cameron.AdventureGame.WinHost
{
    public partial class EditForm : Form
    {
        public EditForm (List<Character>CharacterList,Character character)
        {
            InitializeComponent();
            _characterList=CharacterList;
            _Character=character;
            _RaceComboBox.DataSource=Enum.GetValues(typeof(Character.CharacterRace));
            _ClassComboBox.DataSource=Enum.GetValues(typeof(Character.CharacterClass));

            _CharacterNameTxtBox.Text=character.CharacterName;
            _RaceComboBox.Text=character.SelectedRace.ToString();
            _ClassComboBox.Text=character.SelectedClass.ToString();  
            _StrengthUpDown.Text= character.Strength.ToString();
            _AgilityUpDown.Text= character.Agility.ToString();
            _IntellectUpDown.Text=character.Intelligence.ToString();
            _CharismaUpDown.Text= character.Charisma.ToString();
            _DefenseUpDown.Text= character.Defense.ToString();
            _ConstUpDown.Text= character.Constitution.ToString();


        }

        List<Character> _characterList;
        private Character _character=null;
        public Character _Character { get; private set; }
        public int FreePoints { get; set; }
        private int _freePoints;
        private void AvailableValidation ()
        {
            FreePointLabel.Text=_Character.FreeStatusPoints.ToString();

        }

        private void _AgilityUpDown_ValueChanged ( object sender, EventArgs e )
        {
            _Character.Agility = (int)_AgilityUpDown.Value;
            AvailableValidation();
        }

        private void _IntellectUpDown_ValueChanged ( object sender, EventArgs e )
        {
            _Character.Intelligence = (int)_IntellectUpDown.Value;
            AvailableValidation();
        }

        private void _CharismaUpDown_ValueChanged ( object sender, EventArgs e )
        {
            _Character.Charisma = (int)_CharismaUpDown.Value;
            AvailableValidation();
        }

        private void _DefenseUpDown_ValueChanged ( object sender, EventArgs e )
        {
            _Character.Defense= (int)_DefenseUpDown.Value;
            AvailableValidation();
        }

        private void _ConstUpDown_ValueChanged ( object sender, EventArgs e )
        {
            _Character.Constitution= (int)_ConstUpDown.Value;
            AvailableValidation();
        }

        private void _StrengthUpDown_ValueChanged ( object sender, EventArgs e )
        {
            _Character.Strength = (int)_StrengthUpDown.Value;
            AvailableValidation();
        }
    }
}
