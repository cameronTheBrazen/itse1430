bool isPlaying = true;
int roomNumber = 2;
int lastRoom=2;


int calcValidation ()
{


    if (roomNumber<= 0 || roomNumber == 4)
    { 
        InvalidChoice();
        roomNumber= lastRoom;
        return roomNumber;
    }else if (roomNumber== 8|| roomNumber>=12) {
            InvalidChoice();
            roomNumber= lastRoom;
            return roomNumber;
        }else
    {
        return roomNumber;
    }
        

}
void InvalidChoice () {
    Console.WriteLine("Invalid choice. Please try again");
}
 void Intro ()
{
    Console.WriteLine(" Cameron Kingsley ITSE 1430 9/5/2023");
    Console.WriteLine("You awaken on the floor of a dark room.");
    Console.WriteLine("As your vision begins to clear, yout notice");
    Console.WriteLine("there are two flickering lights on the wall,");
    Console.WriteLine("in two corners. surrounded by 3 large wooden ");
    Console.WriteLine("doorways.and a mirror on the 4th side of the");
    Console.WriteLine(" room.There is nothing else in the room");

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
        Console.WriteLine("room "+ roomNumber);
        return roomNumber;

        case 's':
        case 'S':
        Console.WriteLine("You selected south.");
        roomNumber-=4;
        calcValidation();
        Console.WriteLine("room "+roomNumber);
        return roomNumber;
        case 'e':
        case 'E':

        Console.WriteLine("You selected east.");
        roomNumber +=1;
        calcValidation();
        Console.WriteLine("room "+roomNumber);
        return roomNumber;
        case 'n':
        case 'N':
        Console.WriteLine("You selected north.");
        roomNumber +=4;
        calcValidation();
        Console.WriteLine("room "+roomNumber);
        return roomNumber;
        case 'i':
        case 'I':
        Console.WriteLine("You decided to investigate.");

        Console.WriteLine("room "+roomNumber);
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
        Console.WriteLine("room "+roomNumber);
        return roomNumber;

    };
   
}
 void RoomOne ()
{
    Console.WriteLine("room one");
}
 void RoomTwo ()
{
    Console.WriteLine("test success");
}
 void RoomThree ()
{
    Console.WriteLine("room three");
}
 void RoomFour ()
{
    Console.WriteLine("room four");
}
 void RoomFive ()
{
    Console.WriteLine(" room five");
}
 void RoomSix ()
{
    Console.WriteLine("room six");
}
 void RoomSeven ()
{
    Console.WriteLine("room seven");
}
 void RoomEight ()
{
    Console.WriteLine("room eight");
}
 void RoomNine ()
{
    Console.WriteLine("room nine");
}

Intro();
var v = isPlaying;
while (v)
{
   GameLoop();

   


    switch (roomNumber)
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