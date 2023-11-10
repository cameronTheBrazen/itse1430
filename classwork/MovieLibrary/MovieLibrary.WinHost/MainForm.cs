using MovieLibrary.Memory;

namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }

        private IMovieDatabase _database = new MemoryMovieDatabase();


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
            if (movie == null)
                return;

            var dlg = new MovieForm();
            dlg.Movie = movie;

            do
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                //Edit movie in library
                var error = _database.Update(movie.Id, dlg.Movie);
                if (String.IsNullOrEmpty(error))
                    break;
                MessageBox.Show(this, error, "Updated Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (true);

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
        private void RefreshMovies (bool initial=false)
        {
            _lstMovies.DataSource=null;
            IEnumerable<Movie> movies = _database.GetAll();
            if (initial && !movies.Any() && Confirm("seed", "do you want to seed the database with movies"))
            {
                _database.Seed();
                movies=_database.GetAll();
            }
           
            movies= from m in movies
                    orderby m.Title
                    select m;
            _lstMovies.DataSource= movies.ToArray();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            RefreshMovies(true);
        }

        
    }

}