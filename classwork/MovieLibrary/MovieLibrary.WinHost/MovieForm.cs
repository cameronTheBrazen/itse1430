﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.WinHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }



        private void ComboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void OnSave ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult= DialogResult.Cancel;
            Close();

        }
    }
}
