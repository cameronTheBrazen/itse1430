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

        public Movie Movie { get; set; }


        protected override void OnLoad ( EventArgs e ) { 
            base.OnLoad ( e );
            if (Movie != null) {
                _textBoxTitle.Text=Movie.Title;
                _textBoxDescription.Text=Movie.Description;
                _genreBox.Text= Movie.Genre;
                _ratingBox.Text=Movie.Rating?.Name;
                _textBoxReleaseYear.Text=Movie.ReleaseYear.ToString();
                _textBoxLength.Text= Movie.RunLength.ToString();
                checkBox1.Checked=           Movie.IsBlackAndWhite;
            }
        }
        private void OnSave ( object sender, EventArgs e )
        {
            var movie = new Movie();
            movie.Title = _textBoxTitle.Text;
            movie.Description = _textBoxDescription.Text;
            movie.Genre= _genreBox.Text;
            movie.Rating= new Rating(_ratingBox.Text);
            movie.ReleaseYear=GetInt32(_textBoxReleaseYear, 0);
            movie.RunLength=GetInt32(_textBoxLength, -1);
            movie.IsBlackAndWhite=checkBox1.Checked;


            if (!movie.TryValidate(out var error))
            {
              MessageBox.Show(error, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Movie=movie;
            DialogResult = DialogResult.OK;
            Close();  
            

        }
        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult= DialogResult.Cancel;
            Close();

        }
        private int GetInt32 ( Control control, int defaultValue ) { 
            if (Int32.TryParse( control.Text, out var value ) ) 
                return value;
            return defaultValue;
        }

        
    }
}
