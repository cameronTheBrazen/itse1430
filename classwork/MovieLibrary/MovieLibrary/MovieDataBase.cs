using System;

namespace MovieLibrary;

/// <summary>Represents a database of movies.</summary>
abstract class MovieDatabase : IMovieDatabase
{ 
    public virtual string Add ( Movie movie )
    {
        //Validate: null, invalid movie
        if (movie == null)
            return "Movie is null";
        if (!new ObjectValidator().TryValidate(movie, out var error))
            return error.First().ErrorMessage;

        //Title must be unique
        var existing = FindByTitle(movie.Title);
        if (existing != null)
            return "Movie title must be unique";
        
        var newMovie=AddCore(movie);
        return "";
    }
    protected abstract Movie AddCore ( Movie movie );
   
    public void Delete ( int id )
    {

        DeleteCore(id);  
    }
    protected  abstract void DeleteCore ( int id );

    protected virtual Movie Get ( int id )
    {
        if (id<=0)
        {
           return null;
        }
        return GetCore(id);
    }
    protected abstract Movie GetCore ( int id );
    protected virtual IEnumerable<Movie> GetAll ()
    {

        return GetAllCore();

    }
    protected abstract IEnumerable<Movie> GetAllCore ();
    
   protected virtual string Update ( int id, Movie movie )
    {
        //Validate: null, invalid movie
        if (id <= 0)
            return "ID is invalid";

        if (movie == null)
            return "Movie is null";
        if (!new ObjectValidator().TryValidate(movie, out var error))
            return error.First().ErrorMessage;

        //Title must be unique (and not self)
        var existing = FindByTitle(movie.Title);
        if (existing != null && existing.Id != id)
            return "Movie title must be unique";

        //Movie must exist
        existing = FindById(id);
        if (existing == null)
            return "Movie not found";

        //Update
        UpdateCore(id, movie);
        return "";
    }
    protected abstract void  UpdateCore ( int id, Movie movie );




    #region Private Members





    protected abstract Movie FindById ( int id );


    protected abstract Movie FindByTitle ( string title );

    

   
    
    #endregion
}