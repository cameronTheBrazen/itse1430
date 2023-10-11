namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Movie _movie= new Movie() { Title= "Jaws" };

        
        private void OnAddMovie ( object sender, EventArgs e )
        {
            var dlg= new MovieForm();
            dlg.ShowDialog();
        }

        private void OnEditMovie( object sender, EventArgs e )
        {
            MessageBox.Show("Edit Not implemented");
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
        private void OnFileExit ( object sender, EventArgs e )
        {
            MessageBox.Show("Exit not implemented");
        }
        
    }
}