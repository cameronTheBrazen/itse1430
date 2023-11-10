/*
* ITSE 1430 
* Fall 2023
*/

namespace MovieLibrary.Memory;

/// <summary>Represents a database of movies.</summary>
public class MemoryMovieDatabase : MovieDatabase
{
    /// <inheritdoc />
    protected override Movie AddCore ( Movie movie )
    {
        movie.Id = _id++;
        _movies.Add(Clone(movie));

        return movie;
    }

    /// <inheritdoc />
    protected override void DeleteCore ( int id )
    {
        var movie = FindById(id);
        if (movie != null)
            _movies.Remove(movie);  //Reference equality applies
    }

    /// <inheritdoc />
    protected override Movie GetCore ( int id )
    {
        var movie = FindById(id);
        if (movie == null)
            return null;

        return Clone(movie);
    }

    /// <inheritdoc />
    protected override IEnumerable<Movie> GetAllCore ()
    {

        return from movie in _movies
               select Clone(movie);
    }

    /// <inheritdoc />
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
        return _movies.FirstOrDefault( x => x.Id == id);

        //foreach (var movie in _movies)
        //    if (movie.Id == id)
        //        return movie;

        //return null;

        //return _movies.Where (x=> x.Id == id)
        //        .Select(x=>x).FirstOrDefault();

        //return _movies.Where(MatchMovie)
        //     .Select(SelectMovie)
        //     .FirstOrDefault();


    }
    //private bool MatchMovie(Movie movie )
    //{
    //    return movie.Id == id;
    //}
    //private Movie SelectMovie(Movie movie )
    //{
    //    return movie;
    //}

    protected override Movie FindByTitle ( string title )
    {
        return _movies.FirstOrDefault(x=>String.Equals(title, x.Title, StringComparison.OrdinalIgnoreCase));
    }

    private readonly List<Movie> _movies = new List<Movie>();
    private int _id = 1;
    #endregion
}