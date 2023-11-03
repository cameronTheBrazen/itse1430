using System;

namespace MovieLibrary.Memory;

/// <summary>Represents a database of movies.</summary>
public class MemoryMovieDatabase : MovieDatabase
{
    /// <summary>Initializes an instance of the <see cref="MemoryMovieDatabase"/> class.</summary>
    public MemoryMovieDatabase ()
    {
        
    }

    /// <summary>Adds a movie to the database.</summary>
    /// <param name="movie">The movie to add.</param>
    /// <returns>Empty string if successful or an error message otherwise.</returns>
    /// <remarks>
    /// Movie cannot be null.
    /// Movie must be valid.
    /// Movie title must be unique.
    /// </remarks>
    protected override Movie AddCore ( Movie movie )
    {
        
        movie.Id = _id++;
        _movies.Add(Clone(movie));
        return movie;
    }

    /// <summary>Deletes a movie from the database.</summary>
    /// <param name="id">ID of the movie to delete.</param>
    /// <remarks>
    /// Id must be > 0.
    /// If the movie does not exist then nothing happens.
    /// </remarks>
    protected override void DeleteCore ( int id )
    {
        
        var movie = FindById(id);
        if (movie != null)
            _movies.Remove(movie);  //Reference equality applies
    }
    public override Movie Get ( int id ) {
        var movie = FindById(id);
            if(movie==null ) {
            return null;
            }
        return Clone(movie);
    }
   
    public override IEnumerable<Movie> GetAll ()
    {
        
        var items = new List<Movie>();
        foreach (var movie in _movies)
        {
            yield return Clone(movie);
        }

    }


    protected override void UpdateCore ( int id, Movie movie )
    {
        var existing = FindById(id);
        Copy(existing, movie);
    }

    #region Private Members

    private Movie Clone ( Movie movie )
    {
        var item = new Movie() { Id = movie.Id };
        Copy(item, movie);

        return item;
    }

    private void Copy ( Movie target, Movie source )
    {
        //Don't copy Id
        target.Title = source.Title;
        target.Description = source.Description;
        target.Rating = source.Rating;
        target.ReleaseYear = source.ReleaseYear;
        target.RunLength = source.RunLength;
        target.IsBlackAndWhite = source.IsBlackAndWhite;
        target.Genre = source.Genre;
    }

    protected override Movie FindById ( int id )
    {
        //for (var index = 0; index < _movies.Length; ++index)
        //    if (_movies[index]?.Id == id)
        //        return index;
        foreach (var movie in _movies)
            if (movie.Id == id)
                return movie;

        return null;
    }

    protected override Movie FindByTitle ( string title )
    {
        //for (var index = 0; index < _movies.Length; ++index)
        //    if (String.Equals(title, _movies[index]?.Title, StringComparison.OrdinalIgnoreCase))
        //        return _movies[index];
        foreach (var movie in _movies)
            if (String.Equals(title, movie.Title, StringComparison.OrdinalIgnoreCase))
                return movie;

        return null;
    }

    

    //private readonly Movie[] _movies = new Movie[100];

    //List<T> generic type, resizable array of type T
    private readonly List<Movie> _movies = new List<Movie>();
    private int _id = 1;
    #endregion
}