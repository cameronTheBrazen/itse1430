//     Cameron Kingsley         //
//      August 31, 2023         //
//   ITSE 1430 Adventure Game   //
namespace GameField
{
    class adventure
    {
        char[] north = { 'N', 'n' };
        char[] south = { 'S', 's' };
        char[] east = { 'E', 'e' };
        char[] west = { 'W', 'w' };
        char[] quit = { 'q', 'Q' };
        char[] play = { 'p', 'P' };
        char input = 'Y';
        bool isPlaying = true;
        int[] location ;
        public void Intro ()
        {
            Console.WriteLine(" Cameron Kingsley ITSE 1430 9/5/2023");
            Console.WriteLine("You awaken on the floor of a dark room.");
            Console.WriteLine("As your vision begins to clear, yout notice");
            Console.WriteLine("there are two flickering lights on the wall,");
            Console.WriteLine("in two corners. surrounded by 3 doorways.");
            Console.WriteLine("and a mirror on the 4th side of the room.");
            Console.WriteLine("There is nothing else in the room");

        }
        public void HeadsUpDisplay () {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("N) Move North");
            Console.WriteLine("S) Move South");
            Console.WriteLine("E) Move East");
            Console.WriteLine("W) Move West");
            Console.WriteLine("Q) Quit");
            Console.WriteLine("Select Your Path:");

        }



        public void GameLoop ( )
        {Console.WriteLine("Are you sure you want to quit? Y/N");
            
            input = (char)Console.Read();
                if (input == quit[0]|| input== quit[1])   
                
            input = (char)Console.Read();
                



        }
   

        static void Main ( )
        {
            
             
            adventure adventure;
            adventure = new adventure();
            adventure.Intro();

            adventure.HeadsUpDisplay();
            adventure.GameLoop();

        
        
        
        }


    













    }
}
