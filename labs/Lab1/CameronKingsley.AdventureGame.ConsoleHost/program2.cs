using System.Reflection.Metadata.Ecma335;

bool isPlaying = true;
int adjustedlocation=2;
int roomNumber = 2;
int lastRoom=2;
int currentX=2;
int currentY = 1;

int calcValidation ()
{


    if (roomNumber<= 0 || roomNumber == 4)
    { 
        InvalidChoice();
        roomNumber= lastRoom;
        roomRefactor();
        return roomNumber;
    }else if (roomNumber== 8|| roomNumber>=12) {
            InvalidChoice();
            roomNumber= lastRoom;
        roomRefactor();
            return roomNumber;
       
    }else 
    {
        roomRefactor();
        return roomNumber;
    }
        

}
void roomRefactor () {
    if (roomNumber>4&&roomNumber<8)
    {   

        adjustedlocation = roomNumber-1;
        currentX = adjustedlocation-3;
        currentY=2;
    } else if(roomNumber>8&& roomNumber <12) { 
        adjustedlocation = roomNumber-2;
        currentX = adjustedlocation-6;
        currentY=3;
    } else
    {
        adjustedlocation=roomNumber;
        currentX = roomNumber;
        currentY=1;
    }
}
void displayCoordinate () {

    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine(" You are at position:"+ "E" +currentX+ ", N"+ currentY);
    

}
void InvalidChoice () {
    Console.WriteLine("Invalid choice. Please try again");
}
 void Intro ()
{
    Console.WriteLine("         Cameron Kingsley ITSE 1430 9/5/2023");
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("       You awaken on the floor of a dark room.");
    Console.WriteLine("     As your vision begins to clear, yout notice");
    Console.WriteLine("     there are two flickering lights on the wall,");
    Console.WriteLine("    in two corners, surrounded by 3 large wooden ");
    Console.WriteLine("   doorways.There is a mirror on the 4th side of the");
    Console.WriteLine("  room. Upon The ground is a compass rose painted in red.");
    Console.WriteLine("           The mirror is on the south wall");
    Console.WriteLine("          There is nothing else in the room");

}
void RandomEncounter () {

    var rand= Random.Shared.Next(1, 101);
    if( rand >5)
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("               Everything seems ok."); 
        Console.WriteLine("--------------------------------------------------------");
    }
    else if (rand>=3&& rand <=5) {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("             You hear footsteps behind you."); 
        Console.WriteLine("--------------------------------------------------------");
    }
   else
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("       A shadow passes by the doorway quickly and ");
        Console.WriteLine("  you can make out the vague shape of some large animal");
        Console.WriteLine("--------------------------------------------------------");
    }
}

int GameLoop ()
{

   

    Console.WriteLine("Main Menu:");
    Console.WriteLine("N) Move North");
    Console.WriteLine("S) Move South");
    Console.WriteLine("E) Move East");
    Console.WriteLine("W) Move West");
    Console.WriteLine("I) Investigate");
    Console.WriteLine("Q) Quit");
    Console.WriteLine("Select Your Path:");


    lastRoom= roomNumber;
    char movement = Console.ReadKey(true).KeyChar;


    
    switch (movement)
    {
        case 'w':
        case 'W':
        Console.WriteLine("You selected west.");
        roomNumber= roomNumber-1;
        calcValidation();
        displayCoordinate();
        Console.WriteLine("room "+ adjustedlocation);
        return roomNumber;

        case 's':
        case 'S':
        Console.WriteLine("You selected south.");
        roomNumber-=4;
        calcValidation();
        displayCoordinate();
        Console.WriteLine("room "+ adjustedlocation);
        return roomNumber;
        case 'e':
        case 'E':

        Console.WriteLine("You selected east.");
        roomNumber +=1;
        calcValidation();
        displayCoordinate();
        Console.WriteLine("room "+ adjustedlocation);
        return roomNumber;
        case 'n':
        case 'N':
        Console.WriteLine("You selected north.");
        roomNumber +=4;
        calcValidation();
        displayCoordinate();
        Console.WriteLine("room "+ adjustedlocation);
        return roomNumber;
        case 'i':
        case 'I':
        Console.WriteLine("You decided to investigate.");

        Console.WriteLine("room "+ adjustedlocation);
        return roomNumber;
        case 'q':
        case 'Q':
        Console.WriteLine("Are you sure you want to quit? Y/N");
        var value = Console.ReadKey(true).KeyChar;
        if (value == 'y'||value =='Y' )
        {

           return 0;

        } else
        {
            Console.WriteLine("You have selected to continue!");
            return roomNumber;
        }
        default:
        Console.WriteLine("Select a direction: north, south, east, west. ");
        Console.WriteLine("room "+ adjustedlocation);
        return roomNumber;

    };
   
}
 void RoomOne ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("       There is one flickering light in the corner,");
    Console.WriteLine("      Upon The ground is a compass rose painted in red.");
    Console.WriteLine("        There is a mirror on the south side of the");
    Console.WriteLine("       room. Two doors lie to the north and the east.");
    Console.WriteLine("          Upon the west wall is a mounted deer head.");
    Console.WriteLine("          There is nothing else in the room. ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomTwo ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("     There are two flickering lights on the wall,");
    Console.WriteLine("    in two corners, surrounded by 3 large wooden ");
    Console.WriteLine("   doorways.There is a mirror on the 4th side of the");
    Console.WriteLine("  room. Upon The ground is a compass rose painted in red.");
    Console.WriteLine("           The mirror is on the south wall.");
    Console.WriteLine("          There is nothing else in the room.");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
void RoomThree ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("       There is one flickering light in the corner,");
    Console.WriteLine("      Upon The ground is a compass rose painted in red.");
    Console.WriteLine("        There is a mirror on the south side of the");
    Console.WriteLine("       room. Two doors lie to the north and the west.");
    Console.WriteLine("          Upon the east wall is a stuffed bear statue.");
    Console.WriteLine("          There is nothing else in the room. ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomFour ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("  Upon The ground is a compass rose painted in red.     ");
    Console.WriteLine("In the eastern corners of the room lies 2 flickering lights. ");
    Console.WriteLine("     On the western wall is a mounted deer head.       ");
    Console.WriteLine("     3 doors stand on the North , south , and east .  ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomFive ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("         You are surrounded by 4 doorways.");
    Console.WriteLine("     All four corners of the room have a torch.");
    Console.WriteLine("   In the center of the room lies a table covered");
    Console.WriteLine(" in taxidermy tools. Above is a large windowed ceiling.");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomSix ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("  Upon The ground is a compass rose painted in red.     ");
    Console.WriteLine("In the western corners of the room lies 2 flickering lights. ");
    Console.WriteLine("     On the east wall is a stuffed bear statue.       ");
    Console.WriteLine("     3 doors stand on the North , south , and west .  ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomSeven ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("      Upon The ground is a compass rose painted in red.");
    Console.WriteLine("       There is one flickering light in the south-east corner,");
    Console.WriteLine("        There is a mirror on the north side of the");
    Console.WriteLine("       room. Two doors lie to the south and the east.");
    Console.WriteLine("          Upon the west wall is a mounted deer head.");
    Console.WriteLine("          There is nothing else in the room. ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomEight ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("  Upon The ground is a compass rose painted in red.     ");
    Console.WriteLine("In the southern corners of the room lies 2 flickering lights. ");
    Console.WriteLine("             On the north wall is a mirror.       ");
    Console.WriteLine("     3 doors stand on the west , south , and east .  ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}
 void RoomNine ()
{
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("      Upon The ground is a compass rose painted in red.");
    Console.WriteLine("   There is one flickering light in the south-west corner,");
    Console.WriteLine("        There is a mirror on the south side of the");
    Console.WriteLine("       room. Two doors lie to the south and the west.");
    Console.WriteLine("          Upon the east wall is a stuffed bear statue.");
    Console.WriteLine("          There is nothing else in the room. ");
    Console.WriteLine("--------------------------------------------------------");
    RandomEncounter();
}

Intro();
var v = isPlaying;
while (v)
{
   GameLoop();

   


    switch (adjustedlocation)
    {
        case 1:
        RoomOne();
        break;
        case 2:
        RoomTwo();
        break;
        case 3:
        RoomThree();
        break;
        case 4:
        RoomFour();
        break;
        case 5:
        RoomFive();
        break;
        case 6:
        RoomSix();
        break;
        case 7:
        RoomSeven();
        break;
        case 8:
        RoomEight();
        break;
        case 9:
        RoomNine();
        break;

        default:
        Console.WriteLine("Invalid entry.");
        break;
    };


}