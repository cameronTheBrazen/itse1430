/*Cameron Kingsley
 * ITSE-1430
 */
//DATA: title,genrre,description, rating, 
//length release year, budget,
/// in color?
/// add edit view delete

namespace ConsoleHost 
{
    class Program {

        string title="";
        string genre = "";
        string description = "";
        string rating = "";
        bool inColor = true;
        //in minutes
        int length = 0;
        decimal budget = 0;
        int releaseYear = 1900;

        public void Main ()
        {
            Console.WriteLine("enter a title:");
            title = Console.ReadLine();
            Console.WriteLine("enter a genre:");
            genre = Console.ReadLine();
            Console.WriteLine("enter a description:");
            description = Console.ReadLine();
            Console.WriteLine("enter a rating:");
            rating = Console.ReadLine();
            Console.WriteLine("enter the run length in minutes");
            string lengthString  = Console.ReadLine();





            Console.WriteLine(title);
            Console.WriteLine(genre);
            Console.WriteLine(description);
            Console.WriteLine(rating);
            Console.WriteLine(lengthString);
            Console.WriteLine(budget);
            Console.WriteLine(inColor);
            Console.WriteLine(releaseYear);
        }









    
    }

}