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
string message = "message";

GetMovie();
DisplayMovie();



void GetMovie ()
{
    title = ReadString("enter a title: ",true);
    genre=ReadString("enter a genre: ",true);
    description=ReadString("enter a description: ",false);
    rating= ReadInt("enter a rating: ");
    length= ReadInt("enter the length: ");



}

int ReadInt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result;
    if (Int32.TryParse(value,out result))
        return result;
    return 0;

}


string ReadString( string message, bool isRequired )
{


    Console.WriteLine(message);
    string value = Console.ReadLine();

    if (!isRequired)
        return value;
    return value;
}

void DisplayMovie ()
{
    Console.WriteLine(title);
    Console.WriteLine(genre);
    Console.WriteLine(description);
    Console.WriteLine(rating);
    Console.WriteLine(length);
    Console.WriteLine(budget);
    Console.WriteLine(inColor);
    Console.WriteLine(releaseYear);
}
















