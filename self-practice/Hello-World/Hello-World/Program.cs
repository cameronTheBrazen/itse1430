/*
 * Cameron Kingsley
 * ITSE-1430
 *  
 */
namespace HelloPeeps
{
    class Program
    {
      class Howdy { 
           
        //greeting to test function use 
        public void Greeting ()
        {
            // say hello
            string say = "Hello. ";
            Console.WriteLine(say);

        }
        // second function to test passing variables globally
        public void AskInfo ()
        {
            // ask for name age and goal
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your goal is to:");
            string goal = Console.ReadLine();

        }


      }

            //print final greeting in main
         static void Main()
        {
          Program program = new Program();
               Howdy howdy = new Howdy();
            howdy.Greeting();
            howdy.AskInfo();
            howdy.Greeting();
            


        }

       
    }
}