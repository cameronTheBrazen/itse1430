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
            Console.WriteLine("in two corners. surrounded by 3 large wooden ");
            Console.WriteLine("doorways.and a mirror on the 4th side of the");
            Console.WriteLine(" room.There is nothing else in the room");

        }
        
        public static int GameLoop ( ref int location )
        {
            

            while (location>0&& location<10)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("N) Move North");
                Console.WriteLine("S) Move South");
                Console.WriteLine("E) Move East");
                Console.WriteLine("W) Move West");
                Console.WriteLine("I) Investigate");
                Console.WriteLine("Q) Quit");
                Console.WriteLine("Select Your Path:");
                break;
            }

            char movement = Char.Parse(Console.ReadLine());
            movement = Char.ToUpper(movement);
            switch (movement)
            {

                case 'W':
                Console.WriteLine("You selected west.");
                location = location+1;
                return location;


                case 'S':
                Console.WriteLine("You selected south.");
                location =location+3;
                return location;
                case 'E':

                Console.WriteLine("You selected east.");
                location =location-1;
                return location;

                case 'N':
                Console.WriteLine("You selected north.");
                location =location-3;
                return location;

                case 'I':
                Console.WriteLine("You decided to investigate.");
                
                return location;

                case 'Q':
                Console.WriteLine("Are you sure you want to quit? Y/N");
                var value = Console.ReadLine();
                if (value == "Y"||value == "y")
                {

                    return 0;

                } else
                {
                    Console.WriteLine("You have selected to continue!");
                    return location;
                }
                default:
                Console.WriteLine("Select a direction: north,south,east, west. ");
                return location;

            }
        }
        public void RoomOne ()
        {
            Console.WriteLine("room one");
        }
        public void RoomTwo ()
        {
            Console.WriteLine("test success");
        }
        public void RoomThree ()
        {
            Console.WriteLine("room three");
        }
        public void RoomFour ()
        {
            Console.WriteLine("room four");
        }
        public void RoomFive ()
        {
            Console.WriteLine(" room five");
        }
        public void RoomSix ()
        {
            Console.WriteLine("room six");
        }
        public void RoomSeven ()
        {
            Console.WriteLine("room seven");
        }
        public void RoomEight ()
        {
            Console.WriteLine("room eight");
        }
        public void RoomNine ()
        {
            Console.WriteLine("room nine");
        }
        static void Main ()
        {
            bool isPlaying = true;
            int mainLocale = 2;
            adventure adventure;
            adventure = new adventure();

            adventure.Intro();
            var v = isPlaying;
            while (v)
            {
                adventure.GameLoop(ref mainLocale);

                if (mainLocale == 2 || mainLocale == 3 || mainLocale==1) {

                }
                if (mainLocale == 4 || mainLocale == 7 || mainLocale==1) {

                }
                if (mainLocale == 7 || mainLocale == 8 || mainLocale==9) {

                }
                if (mainLocale == 6 || mainLocale == 3 || mainLocale==9) {

                }



                switch (mainLocale)
                {
                    case 1:
                        adventure.RoomOne();
                    break;
                    case 2:
                        adventure.RoomTwo();    
                    break;
                    case 3:
                        adventure.RoomThree();
                    break;
                    case 4:
                        adventure.RoomFour();
                    break;
                    case 5:
                        adventure.RoomFive();
                    break;
                    case 6:
                        adventure.RoomSix();
                    break;
                    case 7:
                        adventure.RoomSeven();
                    break;
                    case 8:
                        adventure.RoomEight();
                    break;
                    case 9:
                        adventure.RoomNine();
                    break;
                
                    default:
                        Console.WriteLine("Invalid entry.");
                    break;
                }


            }
        }

    }
}



// each room has a feature on the outside wall with torches in the corners of the wall connected to room 5
//outer walls have only four features
// North a mirror
// East a taxidermy eagle
//west a deer head
// south a taxidermy bear
// the central room has a table covered in taxidermy tools
//on the floor of each room is a rug emiting a glow and humming sound.


// the facade of the building is brick and stone mixed and smells earthy.