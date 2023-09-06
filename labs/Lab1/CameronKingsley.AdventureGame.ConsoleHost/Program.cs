//     Cameron Kingsley         //
//      August 31, 2023         //
//   ITSE 1430 Adventure Game   //


namespace GameField
{
    class adventure
    {
        
    
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

        public int GameLoop(){
            int movement = 2;
            int location = 2;
            while (location>0&& location<9) {
               Console.WriteLine("Main Menu:");
               Console.WriteLine("5) Move North");
               Console.WriteLine("2) Move South");
               Console.WriteLine("3) Move East");
               Console.WriteLine("1) Move West");
               Console.WriteLine("9) Quit");
               Console.WriteLine("Select Your Path:");
            
           

                movement = Console.Read();
                switch (movement)
                {
                    case 1:
                    location = location--;
                    return location;
                    
                    case 2:
                    location = location-3;
                    return location;
                    
                    case 3:
                    location = location+1;
                    return location;
                    
                    case 5:
                    location = location+3;
                    return location;
                    
                    case 9:
                    Console.WriteLine("Are you sure you want to quit? Y/N");

                    var value = Console.ReadLine();
                    if (value == "Y"||value == "y")

                        return 0;
                    break;
                    default:
                    Console.WriteLine("Select a direction: north,south,east, west. ");
                    return location;
                    
                }


            


            }
        }
   

        static void Main ( )
        {
            bool isQuitting = false;


            adventure adventure;
            adventure = new adventure();
            adventure.Intro();
            var v = isQuitting;
            while (v) {
                adventure.GameLoop();
            }            

        
        
        
        }

    }
}
