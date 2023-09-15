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

    }
}