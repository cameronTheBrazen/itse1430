namespace MovieLibrary
{/// <summary> represents a single movie</summary>
    public class Movie
    {
        //fields=data in a class

        private string _title;
        /// <summary>title of movie.</summary>
        public string Title
        {
            get {
                if (String.IsNullOrEmpty(_title))
                {
                    return "";
                }
                return _title;
            }
            set {
                if (value!= null)
                    value= value.Trim();
                _title = value;
            }
        }
        private string _description;
        /// <summary>description of movie.</summary>
        public string Description
        {
            get {
                if (String.IsNullOrEmpty(_title))
                {
                    return "";
                }
                return _description;
            }
            set {
                if (value!= null)
                    value= value.Trim();
                _description = value;
            }
        }

        private string _genre;
        /// <summary>genre of movie.</summary>
        public string Genre
        {
            get {
                if (String.IsNullOrEmpty(_title))
                {
                    return "";
                }
                return _genre;
            }
            set {
                if (value!= null)
                    value= value.Trim();
                _genre = value;
            }
        }

        private string _rating;
        /// <summary>rating of movie.</summary>
        public string Rating
        {
            get {
                if (String.IsNullOrEmpty(_title))
                {
                    return "";
                }
                return _rating;
            }
            set {
                if (value!= null)
                    value= value.Trim();
                _rating = value;
            }
        }
        //private int _runLength = 0;
        /// <summary>
        /// LENGTH of the movie
        /// </summary>
        public int RunLength {
            get;
            set;
        }

        //private int _releaseYear = 1900;
        /// <summary>
        /// year of movie release
        /// </summary>
        public int ReleaseYear { get; set; }
        private bool _isBlackAndWhite = false;
        public bool IsBlackAndWhite { get; set; }

        public bool NeedsIntermission
        {
            get { return RunLength>=150; }
            
        }
        ///<summary>Download meta data from the internet</summary>
        //private void DownloadMetaData ()
        // {

        // }
        ///<summary>Validates the movie instance</summary>
        public string Validate ()
        {

            if (String.IsNullOrEmpty(_title))
                return "Title is required!";


            if (ReleaseYear<1900)
                return "Release Year must be greater than 1900";
            if (RunLength<0)
                return "length must be at least 0";



            if (ReleaseYear<1940&& !_isBlackAndWhite)
                return "movies before 1940 must be black and white";

            return "";

        }

    }
}