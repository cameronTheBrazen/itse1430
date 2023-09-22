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




        Character character = null;
        bool characterIsCreated = false;
        int menuInput;

        while (true)
        {
            DisplayMainMenu();

            // Read and validate user input for the main menu
            if (Int32.TryParse(Console.ReadLine(), out menuInput))
            {
                switch (menuInput)
                {
                    case 1:
                    if (characterIsCreated==true)
                    {
                        // View the character
                        Console.Clear();
                        Console.WriteLine("Character Details:");
                        Console.WriteLine($"Race: {character.SelectedRace}");
                        Console.WriteLine($"Class: {character.SelectClass()}");


                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine("Invalid choice"); break;
                    case 2:
                    if (!characterIsCreated)
                    {
                        character = new Character();
                        DisplayRaceMenu(character);
                        DisplayClassMenu(character);
                        characterIsCreated = true;
                    } else
                    {
                        Console.WriteLine("Character already created!");

                        Console.ReadLine();
                    }
                    break;

                    case 3:
                    Environment.Exit(0);
                    break;

                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            } else
            {
                Console.WriteLine("Invalid input. Please enter a valid menu option.");
            }
        }
    }
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

    void DisplayMainMenu ()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Main Menu");
        Console.WriteLine("----------------");
        Console.WriteLine("1)Add Character");
        Console.WriteLine("2) Exit");
        Console.WriteLine("");
        Console.WriteLine("");
    }

}