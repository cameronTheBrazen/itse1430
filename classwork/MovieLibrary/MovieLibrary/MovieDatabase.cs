namespace MovieLibrary;

public class MovieDatabase
{
    public MovieDatabase ()
    {
        _movies[0] = new Movie() {
            Id=_id++,
            Title= "Gone with the wind",
            ReleaseYear= 1978,
            Rating= Rating.PG,
            RunLength= 120,

        }
       
    }

    public string Add ( Movie movie )
    {

        if (movie==null)
        {
            return "movie is null";

        }
        if (!movie.TryValidate(out var error))
        {
            return error;
        }
        var existing = FindByTitle(movie.Title);
        if (existing != null)
        {
            return " movie title must be unique";
        }
        for (var index = 0; index<_movies.Length; index++)
        {
            if (_movies[index] ==null)
            {
                movie.Id=_id++;
                _movies[index]=movie;
                return "";
            }
        }



        return "array is full";
    }

    public void Update ( Movie Movie )
    {

    }
    public void Delete ( int id )
    {
        var index = FindById(id);
        if (index>=0)
        {
            _movies[index]=null;
        }
    }

    public Movie[] GetAll ()
    {
        var count = 0;
        for (var index=0; index<_movies.Length; ++index)
        {
            if (_movies [index] != null)
            {
                count++;
            }
        }
        var items= new Movie[count];
        var itemIndex = 0;
        for (var index = 0; index<_movies.Length; ++index)
        {
            if (_movies[index] != null)
            { items[itemIndex++] = Clone(_movies[index]);
                count++;
            }
        }





        return items;
    }
    private readonly Movie[] _movies = new Movie[100];

    private Movie FindByTitle ( string title )
    {
        for (var index = 0; index<_movies.Length; index++)
        {
            if (String.Equals(title, _movies[index].Title, StringComparison.OrdinalIgnoreCase))
            {
                return _movies[index];
            }
        }
        return null;

    }
    private Movie Clone (Movie movie)
    {
        var clone = new Movie();
        clone.Id=movie.Id;
        clone.Title=movie.Title;
        clone.Description= movie.Description;
        clone.Genre= movie.Genre;
       clone.Rating= movie.Rating;
        clone.ReleaseYear=movie.ReleaseYear;
        clone.RunLength=movie.RunLength;
        clone.IsBlackAndWhite=movie.IsBlackAndWhite;
        return clone;
    }

    private int _id = 1;
    private int FindById ( int id)
    {
        for (var index = 0; index<_movies.Length; index++)
        {
            if (_movies[index]?.Id==id)
            {
                return index;
            }
        }
        return-1;

    }
}
