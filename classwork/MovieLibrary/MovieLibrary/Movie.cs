namespace MovieLibrary
{/// <summary> represents a single movie</summary>
    public class Movie
    {
        //fields=data in a class
        /// <summary>title of movie.</summary>
        public string title = "";
        /// <summary>discription of movie.</summary>
        public string description = "";
        /// <summary>genre of movie.</summary>
        public string genre = "";
        /// <summary>rating of movie.</summary>
        public string rating = "";

        public int length = 0;
        public int releaseYear = 1900;
        public bool isBlackAndWhite = false;


        ///<summary>Download meta data from the internet</summary>
        //private void DownloadMetaData ()
        // {

        // }
        ///<summary>Validates the movie instance</summary>
        public string Validate ()
        {

            if (String.IsNullOrEmpty(title))
                return "Title is required!";


            if (releaseYear<1900)
                return "Release Year must be greater than 1900";
            if (length<0)
                return "length must be at least 0";



            if (releaseYear<1940&& !isBlackAndWhite)
                return "movies before 1940 must be black and white";

            return "";
           
        }

    }
}