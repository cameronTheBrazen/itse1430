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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Character> _characterList = new List<Character>();
       
        public List<Character> CharacterList { get { return _characterList; } }

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
        }

        private void OnAdd ()
        {
            _characterList.Add(new Character());
            RefreshInterface();
        }   

        private void OnAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog();
        }
        public void RefreshInterface ()
        {
            
        }
    }
}
