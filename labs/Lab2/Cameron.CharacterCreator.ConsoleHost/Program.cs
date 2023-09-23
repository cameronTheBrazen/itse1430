// Cameron kingsley
//9/23/2023
//ITSE1430



using Cameron.CharacterCreator;

class Program
{
    static void Main ()
    {
        var app = new Program();
        app.Run();
    }
    void Run ()
    {




        CreationLoop();




    }
    /// <summary>
    /// main loop and functionality of character creation
    /// </summary>
    void CreationLoop ()
    {
        int menuInput;
        Character character = new Character();
        bool characterIsCreated = false;
        while (true)
        {
            DisplayMainMenu(characterIsCreated);

            // Read and validate user input for the main menu

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.V:
                if (characterIsCreated==true)
                {
                    // View the character
                    ViewCharacter(character);
                    break;
                } else
                {
                    Console.WriteLine("Invalid choice"); break;
                }
                case ConsoleKey.A:
                if (characterIsCreated==false)
                {
                    character = new Character();
                    character.CreateName();
                    DisplayRaceMenu(character);

                    DisplayClassMenu(character);
                    if (character.SelectedClass==0)
                    {
                        Console.WriteLine("Class invalid");
                        characterIsCreated = false; break;
                    } else if (character.SelectedRace==0)
                    {
                        Console.WriteLine("Race invalid");
                    } else
                    {
                        Console.WriteLine("Character Created!");
                        characterIsCreated = true; break;
                    }
                } else
                {
                    Console.WriteLine("Character already created!");


                }
                break;

                case ConsoleKey.Q:
                Console.WriteLine("Are you sure you want to quit?\n Y)yes \n N)no");
                switch (Console.ReadKey(true).Key)
                {

                    case ConsoleKey.Y: Environment.Exit(0); break;

                    case ConsoleKey.N: break;

                };



                break;
                case ConsoleKey.E:
                if (characterIsCreated==true)
                {
                    EditStats(character);
                    break;
                } else { break; }
                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
                case ConsoleKey.D:
                if (characterIsCreated==true)
                {
                    Console.WriteLine($"Are you sure you want to Delete {character.CharacterName}?\n Y)yes \n N)no");
                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.Y: character.DeleteCharacter();characterIsCreated=false; break;

                        case ConsoleKey.N: break;

                    }

                }
                break;
            }

        }
    }
    /// <summary>
    /// interface method to select character race
    /// </summary>
    /// <param name="character"></param>
    void DisplayRaceMenu ( Character character )
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Race Menu");
        Console.WriteLine("----------------");
        Console.WriteLine("CHOOSE YOUR RACE!");
        Console.WriteLine(" D) Dwarf");
        Console.WriteLine(" E) Elf");
        Console.WriteLine(" G) Gnome");
        Console.WriteLine(" H) Human");
        Console.WriteLine(" X) Gnoll");

        character.SelectRace();
    }
    /// <summary>
    /// interface method to select class of character
    /// </summary>
    /// <param name="character"></param>
    void DisplayClassMenu ( Character character )
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Class Menu");
        Console.WriteLine("----------------");
        Console.WriteLine("CHOOSE YOUR CLASS!");
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
    /// <summary>
    /// interface method to view main menu
    /// </summary>
    /// <param name="characterIsCreated"></param>
    void DisplayMainMenu ( bool characterIsCreated )
    {
        if (characterIsCreated==false)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Main Menu");
            Console.WriteLine("----------------");
            Console.WriteLine("A)Add Character");
            Console.WriteLine("Q) Exit");
        } else
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Main Menu");
            Console.WriteLine("-----------" +
                "-----");
            Console.WriteLine("A)Add Character");
            Console.WriteLine("V) View Character");
            Console.WriteLine("E) Edit Stats");
            Console.WriteLine("D) Delete Character");
            Console.WriteLine("Q) Exit");
        }
    }
    /// <summary>
    /// interface method to view character stats
    /// </summary>
    /// <param name="character"></param>
    void ViewCharacter ( Character character )
    {

        Console.WriteLine("Character Details:");
        Console.WriteLine($"Name:   {character.CharacterName}");
        Console.WriteLine($"Race:  {character.SelectedRace}");
        Console.WriteLine($"Class: {character.SelectedClass}");
        Console.WriteLine($"Strength:     {character.Strength}");
        Console.WriteLine($"Intelligence: {character.Intelligence}");
        Console.WriteLine($"Defense:      {character.Defense}");
        Console.WriteLine($"Agility:      {character.Agility}");
        Console.WriteLine($"Constitution: {character.Constitution}");
        Console.WriteLine($"Charisma:     {character.Charisma}");
        Console.WriteLine($"Availble Status Points:         {character.FreeStatusPoints}");
    }
    /// <summary>
    /// interface method for stat modification
    /// </summary>
    /// <param name="character"></param>
    void EditStats ( Character character )
    {
        bool backingUp = false;
        while (backingUp==false)
        {
            Console.WriteLine("select a Stat to reduce.");
            Console.WriteLine(" S)Strength\n I)Intelligence\n D)Defense \n A)Agility \n C)Constitution\n M)Charisma\n Q)GO BACK");
            character.ReduceStats(backingUp);
            ViewCharacter(character);
        }
        while (backingUp==false)
        {
            Console.WriteLine("select a Stat to increase.");
            character.IncreaseStats(backingUp);
        }
    }



}