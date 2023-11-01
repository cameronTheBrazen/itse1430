using System.ComponentModel.DataAnnotations;

namespace MovieLibrary
{/// <summary> represents a single movie</summary>
    public class Movie : IValidatableObject
    {
        /// <summary>
        ///  Initializes the movie class        
        /// </summary>
        /// <param name="id">Identifier of the movie</param>
        public Movie ()
        {
            _initialized = true;
        }

        public Movie ( int id ) : this(id, "")
        {
            //Id= id;
        }
        public Movie ( string title ) : this(0, title)
        {

        }
        public Movie ( int id, string title ) : this()
        {
            //Id= id;
            //Title= title;
        }


        //fields=data in a class
        /// <summary>
        /// minimum release year
        /// </summary>
        public const int MinimumReleaseYear = 1900;
        public int Id { get;  set; }

        private bool _initialized;
        private string _title;
        /// <summary>title of movie.</summary>
        public string Title
        {
            get {

                return _title ?? "";
            }
            set {
                //if (value!= null)
                //    value= value.Trim();
                //_title = value;
                _title= value?.Trim()??"";
            }
        }
        private string _description;
        /// <summary>description of movie.</summary>
        public string Description
        {
            get {
                return _description ?? "";
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
                return _genre ?? "";
            }
            set {
                if (value!= null)
                    value= value.Trim();
                _genre = value;
            }
        }

        private Rating _rating;
        /// <summary>rating of movie.</summary>
        public Rating Rating
        {
            get {
                if (String.IsNullOrEmpty(_title))
                {
                    return Rating.PG;
                }
                return _rating;
            }
            set {
                if (value!= null)

                    _rating = value;
            }
        }
        //private int _runLength = 0;
        /// <summary>
        /// LENGTH of the movie
        /// </summary>
        public int RunLength
        {
            get;
            set;
        }

        //private int _releaseYear = 1900;
        /// <summary>
        /// year of movie release
        /// </summary>
        public int ReleaseYear { get; set; } = MinimumReleaseYear;
        private bool _isBlackAndWhite = false;
        public bool IsBlackAndWhite { get; set; }

        public bool NeedsIntermission
        {
            get { return RunLength>=150; }

        }


       
        public override string ToString ()
        {
            return $"{Title}[{ReleaseYear}]";
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(_title))
            { yield return new ValidationResult("Title is required!");
            }
            if (ReleaseYear<MinimumReleaseYear)
            {
                yield return new ValidationResult($"Release Year must be greater than {MinimumReleaseYear}");

                
            }
            if (RunLength<0)
            {
                yield return new ValidationResult("length must be at least 0");
                
                     }

            if (ReleaseYear<1940&& !_isBlackAndWhite)
            {
                yield return new ValidationResult("movies before 1940 must be black and white");
                
            }
            
        }
    }

}