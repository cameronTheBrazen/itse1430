
namespace MovieLibrary
{/// <summary>
/// represents an mpaa rating
/// </summary>
    public class Rating
    {
        public Rating ( string name )
        {
            Name=String.IsNullOrEmpty(name) ? "" : name;
        }
        public static readonly Rating G = new Rating("G");
        public static readonly Rating PG = new Rating("PG");
        public static readonly Rating PG13 = new Rating("PG13");
        public static readonly Rating R = new Rating("R");




        /// <summary>
        /// Gets rating name
        /// </summary>
        public string Name { get; }

        public override string ToString ()
        {
            return Name;
        }






    }
}
