//     Cameron Kingsley         //
//      August 31, 2023         //
//   ITSE 1430 Adventure Game   //
using System;
using System.ComponentModel.Design;

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
        // not all code paths return a value in Gameloop
        public static int GameLoop (ref int location){
            
            
            while (location>0&& location<10) {
               Console.WriteLine("Main Menu:");
               Console.WriteLine("N) Move North");
               Console.WriteLine("S) Move South");
               Console.WriteLine("E) Move East");
               Console.WriteLine("W) Move West");
               Console.WriteLine("Q) Quit");
               Console.WriteLine("Select Your Path:");
            
           
                
               char movement = Char.Parse(Console.ReadLine());
                movement = Char.ToUpper(movement);
                switch (movement)
                {

                    case 'W':
                    Console.WriteLine("You selected west.");
                    location = location-1;
                    return location;


                    case 'S':
                    Console.WriteLine("You selected south.");
                    location =location-3;
                    return location;
                    case 'E':

                    Console.WriteLine("You selected east.");
                    location =location+1;
                    return location;

                    case 'N':
                    Console.WriteLine("You selected north.");
                    location =location+3;
                    return location;
                    case 'Q':

                    Console.WriteLine("Are you sure you want to quit? Y/N");

                    var value = Console.ReadLine();
                    if (value == "Y"||value == "y") {

                        return 0;

                    } else {
                        Console.WriteLine("You have selected to continue!");
                    return location;
                    }
                    default:
                    Console.WriteLine("Select a direction: north,south,east, west. ");
                    return location;
                    
                }


            


            }
        }
   

        static void Main ( )
        {
            bool isQuitting = false;
            int mainLocale=2;
            adventure adventure;
            adventure = new adventure();

            adventure.Intro();
            var v = isQuitting;
            while (v) {
                adventure.GameLoop(ref mainLocale);
            }            

        
        
        
        }

    }
}
