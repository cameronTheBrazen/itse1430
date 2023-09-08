bool isPlaying = true;
int roomNumber = 2;
int currentX=2;
int maxX = 3;
int currentY=1;
int maxY = 3;

int calcValidation ()
{


    if (currentX >= 1 && currentX < maxX && currentY >= 1 && currentY < maxY)
    { 
       return roomNumber = currentX + (maxX * (currentY - 1));
    }else
    {
        return roomNumber;
    }
        

}
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



    char movement = Char.ToUpper(Char.Parse(Console.ReadLine()));


    ;
    switch (movement)
    {

        case 'W':
        Console.WriteLine("You selected west.");
        currentX-=1;
        calcValidation();
        Console.WriteLine(roomNumber);
        return roomNumber;


        case 'S':
        Console.WriteLine("You selected south.");
        currentY -=1;
        calcValidation();
        Console.WriteLine(roomNumber);
        return roomNumber;
        case 'E':

        Console.WriteLine("You selected east.");
        currentX +=1;
        calcValidation();
        Console.WriteLine(roomNumber);
        return roomNumber;

        case 'N':
        Console.WriteLine("You selected north.");
        currentY +=1;
        calcValidation();
        Console.WriteLine(roomNumber);
        return roomNumber;

        case 'I':
        Console.WriteLine("You decided to investigate.");

        Console.WriteLine(roomNumber);
        return roomNumber;

        case 'Q':
        Console.WriteLine("Are you sure you want to quit? Y/N");
        var value = Console.ReadLine();
        if (value == "Y"||value == "y")
        {

            return 0;

        } else
        {
            Console.WriteLine("You have selected to continue!");
            return roomNumber;
        }
        default:
        Console.WriteLine("Select a direction: north, south, east, west. ");
        Console.WriteLine(roomNumber);
        return roomNumber;

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

Intro();
var v = isPlaying;
while (v)
{
   GameLoop();

    roomNumber = currentX + (maxX * (currentY - 1));


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
    }


}