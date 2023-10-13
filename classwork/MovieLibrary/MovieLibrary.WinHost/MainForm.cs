namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }

        private Movie _movie;


        private void OnAddMovie ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            if (dlg.ShowDialog()!= DialogResult.OK)
                return;
            _movie= dlg.Movie;
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

            _movie= dlg.Movie;
            RefreshMovies();
        }

        private void OnDeleteMovie ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie== null)
                return;
            if (!Confirm("Delete", $"Are you sure you want to delete'{movie.Title}'")) {


                return;
            }

            _movie= null;
            RefreshMovies();
        }
        private Movie GetSelectedMovie ()
        {
            return _movie;
        }
        private bool Confirm ( string title, string message )
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes;

        }
        private void OnHelpAbout ( object sender, EventArgs e ) {
            var about = new About();
            about.ShowDialog();
        }
        protected override void OnFormClosing ( FormClosingEventArgs e ) {
            if (_movie != null) {
                             //window bar,    in the form
                if (!Confirm("Do you want to exit", "exit"))
                {
                    e.Cancel=true;
                    return;
                }
            }
            base.OnFormClosing( e );
        }
        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }
        private void RefreshMovies ()
        {
            _lstMovies.DataSource=null;
            if (_movie!=null) {
                _lstMovies.DataSource=new[] { _movie };
            }
        }
    }
}