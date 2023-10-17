﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Character> _characterList = new List<Character>();

        public List<Character> CharacterList
        {
            get { 
                return _characterList;
            }
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();

        }
        private void OnClosing( object sender, FormClosingEventArgs e )
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
        private void OnOpeningNewCharacter (object sender, EventArgs e)
        {
            var dlg = new CharacterForm();
            dlg.ShowDialog();
        }
        private void OnAdd ()
        {
            
            RefreshInterface(Get_characterList());
        }   

        private void OnAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog();
        }
        private Character GetCharacter (){
            return _character;
        }

        public List Get_characterList ()
        {
            return _characterList;
        }

        public void RefreshInterface ( Character _characterList )
        {
            _characterList=_character;

                //HACK: Fix this
                if (_character != null)
                _characterList.DataSource = new[] { _character };
            
        }
        private Character _character= new Character();
        

        private void OnMainForm_Load ( object sender, EventArgs e )
        {
            if ( _character != null )
            {
                RefreshInterface(Get_characterList());
            }
        }
    }

    public class List
    {
    }
}
