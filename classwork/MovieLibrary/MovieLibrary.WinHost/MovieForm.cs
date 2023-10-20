namespace MovieLibrary.WinHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        public Movie Movie { get; set; }


        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            if (Movie != null)
            {
                _textBoxTitle.Text=Movie.Title;
                _textBoxDescription.Text=Movie.Description;
                _genreBox.Text= Movie.Genre;
                _ratingBox.Text=Movie.Rating?.Name;
                _textBoxReleaseYear.Text=Movie.ReleaseYear.ToString();
                _textBoxLength.Text= Movie.RunLength.ToString();
                checkBox1.Checked=           Movie.IsBlackAndWhite;
            }
            ValidateChildren();
        }
        private void OnSave ( object sender, EventArgs e )
        {

            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }
            var button = sender as Button;
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
        private int GetInt32 ( Control control, int defaultValue )
        {
            if (Int32.TryParse(control.Text, out var value))
                return value;
            return defaultValue;
        }
        private void OnValidateTitle ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_textBoxTitle.Text))
            {
                //Invalid
                _errors.SetError(_textBoxTitle, "Title is required");
                e.Cancel = true;
            } else
                _errors.SetError(_textBoxTitle, "");
        }

        private void OnValidateReleaseYear ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var value = GetInt32(_textBoxReleaseYear, 1);
            if (value < 1900)
            {
                //Invalid
                _errors.SetError(_textBoxReleaseYear, "Release Year must be at least 1900");
                e.Cancel = true;
            } else
                _errors.SetError(_textBoxReleaseYear, "");
        }

        private void OnValidateRunLength ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var value = GetInt32(_textBoxLength, -1);
            if (value < 0)
            {
                //Invalid
                _errors.SetError(_textBoxLength, "Run Length must be >= 0");
                e.Cancel = true;
            } else
                _errors.SetError(_textBoxLength, "");
        }

        private void OnValidateRating ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_ratingBox.Text))
            {
                //Invalid
                _errors.SetError(_ratingBox, "Rating is required");
                e.Cancel = true;
            } else
                _errors.SetError(_ratingBox, "");
        }
    }

}

