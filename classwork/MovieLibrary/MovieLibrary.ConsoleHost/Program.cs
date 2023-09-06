/*Cameron Kingsley
 * ITSE-1430
 */
//DATA: title,genrre,description, rating, 
//length release year, budget,
/// in color?
/// add edit view delete





string title = "";
string genre = "";
string description = "";
int rating = 0;
bool inColor = true;
//in minutes
int length = 0;
decimal budget = 0;
int releaseYear = 1900;
string message = "";

GetMovie();
DisplayMovie();



void GetMovie ()
{
    title = ReadString("enter a title: ",true);
    genre=ReadString("enter a genre: ",true);
    description=ReadString("enter a description: ",false);
    rating= ReadInt("enter a rating: ", 1);
    length= ReadInt("enter the length: ",0);
    releaseYear=ReadInt("Enter the release year", 1900);
    inColor=ReadBool("In color Y/N? ");

}

int ReadInt (string message,int minimumValue)
{
    Console.WriteLine(message);
    do
    {
        string value = Console.ReadLine();
        
        if (Int32.TryParse(value, out var result))
            if (result >= minimumValue)
                return result;
        Console.WriteLine("value must be at least " + minimumValue);
    }while(true);
}


string ReadString( string message, bool isRequired )
{
    do
    {
        Console.WriteLine(message);
        string value = Console.ReadLine();

        if (!isRequired || value != "")
            return value;
        
        Console.WriteLine("Value is required.");
    }while(true);
}

bool ReadBool (string message) { 
    Console.WriteLine(message);
    while (true) {
        var value = Console.ReadLine();
        if (value == "Y"||value == "y")

            return true;
        else if (value == "N"||value == "n")
            return false;
        Console.WriteLine("Please enter Y or N");
       
        
    
    };
}

void DisplayMovie ()
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine(title);
    Console.WriteLine(genre);
    Console.WriteLine(description);
    Console.WriteLine(rating + " stars");
    Console.WriteLine("Run Length: " + length + "mins");
    Console.WriteLine(budget);

    string format = inColor ? "Color" : "Black and white";
    Console.WriteLine("Format: " + format);
    Console.WriteLine("released" + releaseYear);
}
















