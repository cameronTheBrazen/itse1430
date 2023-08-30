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
        public void AskInfo (ref string name,ref int age,ref string goal)
        {
            // ask for name age and goal
            Console.WriteLine("What is your name?");
              name = Console.ReadLine();
            Console.WriteLine("What is your age?");
              age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your goal is to:");
             goal = Console.ReadLine();

        }
        public void useInfo ()
            {
              
                
            }







      }

            //print final greeting in main
         static void Main()
        {
            Program program = new Program();
                           Howdy howdy = new Howdy();
            string user;
            string target;
            int youth=0 ;

          
            howdy.Greeting();
            howdy.AskInfo(ref user,ref youth,ref target);
            howdy.Greeting();
            howdy.useInfo();


        }

       
    }
}