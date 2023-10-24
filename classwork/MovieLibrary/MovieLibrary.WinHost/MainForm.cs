namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }

        private MovieDatabase _database = new MovieDatabase();


        private void OnAddMovie ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            do
            {
                if (dlg.ShowDialog()!= DialogResult.OK)
                    return;
                //_movie= dlg.Movie;
                var error = _database.Add(dlg.Movie);
                if (String.IsNullOrEmpty(error))
                { break; }
                MessageBox.Show(this, error, "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (true);
            RefreshMovies();
        }

        private void OnEditMovie ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie== null)
                return;

            var dlg = new MovieForm();
            dlg.Movie=movie;
            if (dlg.ShowDialog()!= DialogResult.OK)
                return;

            _database.Update(dlg.Movie);
            RefreshMovies();
        }

        private void OnDeleteMovie ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie== null)
                return;
            if (!Confirm("Delete", $"Are you sure you want to delete'{movie.Title}'"))
            {


                return;
            }

            _database.Delete(movie.Id);
            RefreshMovies();
        }
        private Movie GetSelectedMovie ()
        {
            return _lstMovies.SelectedItem as Movie;
        }
        private bool Confirm ( string title, string message )
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes;

        }
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new About();
            about.ShowDialog();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }
        private void RefreshMovies ()
        {
            _lstMovies.DataSource=null;
            var movies = _database.GetAll();
            _lstMovies.DataSource= movies;

        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            RefreshMovies();
        }


    }

}