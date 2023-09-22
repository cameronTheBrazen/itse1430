// Movie data:
//  Title, genre, description, mpaa rating
//  Length, release year, budget
//  IsBlackAndWhite
// Operations: Add, edit, view, delete

//Movie details

// REMOVE VARIABLES
using MovieLibrary;

partial class Program
{
    static void Main ()
    {
        var app = new Program();
        app.Run();
    }
    void Run ()
    {
        Movie movie = new Movie();
        //program entry point
        var done = false;
        do
        {

            switch (DisplayMenu())
            {
                case MenuCommand.Add: movie = AddMovie(); break;
                case MenuCommand.Edit: EditMovie(); break;
                case MenuCommand.Delete:
                {
                    if (DeleteMovie(movie))
                        movie= new Movie();
                    break;
                }
                case MenuCommand.View: ViewMovie(movie); break;
                case MenuCommand.Quit:
                {
                    done = true;

                    break;
                };

                default: Console.WriteLine("Unknown option"); break;
            };
        } while (!done);

    }

    MenuCommand DisplayMenu ()
    {
        Console.WriteLine("-----------");
        Console.WriteLine("A)dd Movie");
        Console.WriteLine("E)dit Movie");
        Console.WriteLine("D)elete Movie");
        Console.WriteLine("V)iew Movie");
        Console.WriteLine("Q)uit");

        do
        {

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.A: return MenuCommand.Add;

                case ConsoleKey.E: return MenuCommand.Edit;

                case ConsoleKey.D: return MenuCommand.Delete;

                case ConsoleKey.V: return MenuCommand.View;

                case ConsoleKey.Q: return MenuCommand.Quit;
            };
        } while (true);
    }

    Movie AddMovie ()
    {
        var movie = new Movie();
        do
        {
            movie.Title = ReadString("Enter a title: ", true);
            movie.Description = ReadString("Enter a description: ", false);

            movie.RunLength = ReadInt("Enter the run length (in mins): ", 0);
            movie.ReleaseYear = ReadInt("Enter the release year: ", 1900);

            movie.Genre = ReadString("Enter a genre: ", false);
            movie.Rating = ReadRating("Enter a rating: ");

            movie.IsBlackAndWhite = ReadBoolean("Black and White (Y/N)?");
            var error = movie.Validate();
            if (String.IsNullOrEmpty(error))
             Console.WriteLine($"ERROR: {error}");
            return movie;
           
        } while (true);

    }
    void EditMovie ()
    {
        Console.WriteLine("Not implemented yet");
    }

    bool DeleteMovie ( Movie movie )
    {
        if (String.IsNullOrEmpty(movie.Title))
            return false;
        if (!Confirm($"Are you sure you want to delete the movie '{movie.Title}' (Y/N)?"))
            return false;
        //TODO: DELETE MOVIE
        //movie.title = "";
        return true;
    }

    //Display the movie details
    void ViewMovie ( Movie movie )
    {

        if (String.IsNullOrEmpty(movie.Title))
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("No movies available.");
            return;
        }
        Console.WriteLine("\n--------------");
        Console.WriteLine(movie.Title);
        string message2 = $"Run Length:{movie.RunLength} mins";
        Console.WriteLine(message2);
        if (movie.NeedsIntermission==true)
        {
            Console.WriteLine("Intermission necessary");
        }
        Console.WriteLine($"Released: {movie.ReleaseYear}");
        Console.WriteLine(movie.Genre);
        Console.WriteLine($"MPAA Rating: {movie.Rating}");
        string format = movie.IsBlackAndWhite ? "Black and White" : "Color";
        Console.WriteLine("Format: " + format);
        Console.WriteLine(movie.Description);
    }

    bool Confirm ( string message )
    {
        return ReadBoolean(message);
    }
    ///<summary>reads a boolean</summary>
    /// <param name="message">messsage to show</param>
    /// <returns> true if value was true  otherwise false</returns>
    bool ReadBoolean ( string message )
    {
        Console.WriteLine(message);

        //Handle errors
        while (true)
        {

            switch (Console.ReadKey(true).Key)
            {

                case ConsoleKey.Y: return true;

                case ConsoleKey.N: return false;

            };
        };
    }

    int ReadInt ( string message, int minimumValue )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine();


            if (Int32.TryParse(value, out var result))
                if (result >= minimumValue)
                    return result;

            Console.WriteLine("Value must be at least " + minimumValue);
        } while (true);
    }

    string ReadRating ( string message )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine();
            if (String.Equals(value, "PG", StringComparison.CurrentCultureIgnoreCase))
                return "PG";
            else if (String.Equals(value, "G", StringComparison.CurrentCultureIgnoreCase))
                return "G";
            else if (String.Equals(value, "PG-13", StringComparison.CurrentCultureIgnoreCase))
                return "PG-13";
            else if (String.Equals(value, "R", StringComparison.CurrentCultureIgnoreCase))
                return "R";

            else if (String.IsNullOrEmpty(value))
                return "";

            Console.WriteLine("Invalid rating");
        } while (true);
    }

    string ReadString ( string message, bool isRequired )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine().Trim();

            if (!isRequired || !String.IsNullOrEmpty(value))
                return value;


            Console.WriteLine("Value is required");
        } while (true);
    }
}


#region Demo Code

//void Demo ()
//{
//Playing with strings
//string someValue = 10.ToString(); //"10"
//someValue = (4 + 5).ToString(); // "9"

////Escape characters
//someValue = "Hello\"Bob";
//string filePath = "C:\\windows\\temp";
//filePath = @"C:\windows\temp";  //Verbatim string
////filePath = """file="somevalue";file="somevalue2""""

//double someFloatingValue = 3.14159;
//char letterGrade = 'A';

//{
//    int hours = 5;
//    //int title = 54;
//    title = "Jaws";

//    Console.WriteLine(title);
//    Console.WriteLine(length);
//}


//Playing with strings 2
//string emptyValue;
//var areEqual = "" == String.Empty;  //true
//areEqual = "" == null;  //false
//}
#endregion