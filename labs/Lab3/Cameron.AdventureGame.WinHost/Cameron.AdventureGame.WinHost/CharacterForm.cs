﻿using System;
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
            Character= new Character();
        }

        public Character Character { get; private set; }

        private void OnSave (object sender, EventArgs e)
        {
            var button= sender as Button;   
            
            Character.CharacterName = _CharacterNameTxtBox.Text;
            Character.SelectedRace= (Character.CharacterRace)_ClassComboBox.SelectedIndex;
            
            Character.SelectedClass=(Character.CharacterClass)_RaceComboBox.SelectedIndex;
            Character.SetClassStats();

            if (!Character.TryValidate(out var error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            
            DialogResult = DialogResult.OK;
            Close();

        }
        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnRandom ( object sender, EventArgs e )
        {
           
            Character.RandomToon();

        }

        
        private void OnRaceChoice ( object sender, EventArgs e )
        {
            
            var SelectedRace= (Character.CharacterRace)_ClassComboBox.SelectedIndex;
            Character.SelectedRace=SelectedRace;
           
        }

        private void OnClassChoice ( object sender, EventArgs e )
        {

            Character.SelectedClass=(Character.CharacterClass)_RaceComboBox.SelectedIndex;
            Character.SetClassStats();
            DisplayStats();
           
        }
        private void DisplayStats ()
        {
            if (Character != null)
            {
                _StrengthListBox.Text= Character.Strength.ToString();
                _AgilityListBox.Text= Character.Agility.ToString(); 
                _IntellectListBox.Text=Character.Intelligence.ToString();
                _CharismaListBox.Text= Character.Charisma.ToString();
                _DefenseListBox.Text= Character.Defense.ToString();
                _ConstitutionListBox.Text= Character.Constitution.ToString();
            }
        }

        private void CharacterForm_Load ( object sender, EventArgs e )
        {
           
            Character character= new Character();
          _RaceComboBox.DataSource=Enum.GetValues(typeof(Character.CharacterRace));
            _ClassComboBox.DataSource=Enum.GetValues(typeof(Character.CharacterClass));
        }

        private void _StrengthListBox_SelectedIndexChanged ( object sender, EventArgs e )
        {
            AffixDataSource();
        }
        private void AffixDataSource () {
            _StrengthListBox.DataSource= Character.Strength;
            _IntellectListBox.DataSource=Character.Intelligence;
            _AgilityListBox.DataSource= Character.Agility;
            _CharismaListBox.DataSource= Character.Charisma;
            _DefenseListBox.DataSource= Character.Defense;
            _ConstitutionListBox.DataSource= Character.Constitution;
            DisplayStats();
        }
    
    
    }
   
}
