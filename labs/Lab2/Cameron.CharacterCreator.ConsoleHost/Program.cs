using Cameron.CharacterCreator;

var menuInput = 0;
Character character = new Character();

DisplayRaceMenu();
DisplayClassMenu();
Character.CharacterRace DisplayRaceMenu ()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("----------------");
    Console.WriteLine("CHOOSE YOUR RACE!");
    Console.WriteLine(" D) Dwarf");
    Console.WriteLine(" E) Elf");
    Console.WriteLine(" G) Gnome");
    Console.WriteLine(" H) Human");
    Console.WriteLine(" X) Gnoll");

    bool valid;
    // add character; quit; 
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D: valid=true; return Character.CharacterRace.Dwarf;
        case ConsoleKey.E: valid=true; return Character.CharacterRace.Elf;
        case ConsoleKey.G: valid=true; return Character.CharacterRace.Gnome;
        case ConsoleKey.H: valid=true; return Character.CharacterRace.Human;
        case ConsoleKey.X: valid=true; return Character.CharacterRace.Gnoll;
        default: valid=false; Console.WriteLine("Invalid Choice"); break;
    }

}

Character.CharacterClass DisplayClassMenu ()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("----------------");
    Console.WriteLine("CHOOSE YOUR RACE!");
    Console.WriteLine(" P)Paladin ");
    Console.WriteLine(" C)Cleric");
    Console.WriteLine(" W)Warrior");
    Console.WriteLine(" R)Rogue");
    Console.WriteLine(" M)Mage");
    Console.WriteLine(" Z) Wizard");
    Console.WriteLine(" S)SpellSword");
    Console.WriteLine(" D)ShieldWarden");



    character.SelectClass();
}


 