namespace Cameron.CharacterCreator
{
    public class Character
    {



        public enum CharacterRace
        {
            Dwarf = 1,
            Elf = 2,
            Gnome = 3,
            Human = 4,
            Gnoll = 5,
            InvalidChoice = 0
        };
        public enum CharacterClass
        {
            Paladin = 1,
            Cleric = 2,
            Warrior = 3,
            Rogue = 4,
            Mage = 5,
            Wizard = 6,
            SpellSword = 7,
            ShieldWarden = 8,
            InvalidChoice = 0
        };
        private Character.CharacterRace _selectedRace;
        public CharacterRace SelectedRace { get => _selectedRace; set => _selectedRace=value; }
        private Character.CharacterClass _selectedClass;
        public CharacterClass SelectedClass { get; set; }
        private int _strength = 1;
        /// <summary>
        /// Strength Stat for character
        /// </summary>
        public int Strength { get { return _strength; } set { _strength = value; } }
        private int _intelligence = 1;
        /// <summary>
        /// Intelligence Stat for character
        /// </summary>

        public int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        private int _defense = 1;
        /// <summary>
        /// Defense Stat for character
        /// </summary>
        public int Defense { get { return _defense; } set { _defense = value; } }
        private int _agility = 1;
        /// <summary>
        /// Agility Stat for character
        /// </summary>
        public int Agility { get; set; }
        private int _constitution = 1;
        /// <summary>
        /// Constitution Stat for character
        /// </summary>
        public int Constitution { get; set; }
        private int _charisma = 1;
        /// <summary>
        /// Charisma Stat for character
        /// </summary>
        public int Charisma { get; set; }

        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void PaladinBase ()
        {
            Strength=60;
            Intelligence=60;
            Defense= 80;
            Agility=10;
            Constitution= 50;
            Charisma= 40;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void ClericBase ()
        {
            Strength=40;
            Intelligence=70;
            Defense= 80;
            Agility=10;
            Constitution= 50;
            Charisma= 50;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void WarriorBase ()
        {
            Strength= 100;
            Intelligence= 10;
            Defense= 80;
            Agility= 20;
            Constitution= 50;
            Charisma= 40;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void RogueBase ()
        {
            Strength= 10;
            Intelligence=60;
            Defense= 50;
            Agility=90;
            Constitution= 50;
            Charisma= 40;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void MageBase ()
        {
            Strength= 10;
            Intelligence=100;
            Defense= 10;
            Agility=80;
            Constitution= 20;
            Charisma= 80;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void WizardBase ()
        {
            Strength= 10;
            Intelligence=100;
            Defense= 10;
            Agility=20;
            Constitution= 80;
            Charisma= 80;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void SpellSwordBase ()
        {
            Strength= 10;
            Intelligence=100;
            Defense= 10;
            Agility=80;
            Constitution= 20;
            Charisma= 80;


        }
        /// <summary>
        /// Sets base stats 
        /// </summary>
        private void ShieldWardenBase ()
        {
            Strength= 40;
            Intelligence=40;
            Defense= 70;
            Agility=40;
            Constitution= 70;
            Charisma= 40;


        }



        public Character.CharacterClass SelectClass ()
        {
            bool valid = true;
            // add character; quit; 
            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.P: valid=true; return Character.CharacterClass.Paladin;
                    case ConsoleKey.C: valid=true; return Character.CharacterClass.Cleric;
                    case ConsoleKey.W: valid=true; return Character.CharacterClass.Warrior;
                    case ConsoleKey.R: valid=true; return Character.CharacterClass.Rogue;
                    case ConsoleKey.M: valid=true; return Character.CharacterClass.Mage;
                    case ConsoleKey.Z:
                    valid=true;
                    return Character.CharacterClass.Wizard;
                    case ConsoleKey.S:
                    valid=true;
                    return Character.CharacterClass.SpellSword;
                    case ConsoleKey.D: valid=true; return Character.CharacterClass.ShieldWarden;
                    default: valid=false; Console.WriteLine("Invalid Choice"); return CharacterClass.InvalidChoice;


                }
            } while (valid==false);
        }


        public Character.CharacterRace SelectRace ()
        {

            bool valid;
            do
            {
                // add character; quit; 
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D: valid=true; return Character.CharacterRace.Dwarf;
                    case ConsoleKey.E: valid=true; return Character.CharacterRace.Elf;
                    case ConsoleKey.G: valid=true; return Character.CharacterRace.Gnome;
                    case ConsoleKey.H: valid=true; return Character.CharacterRace.Human;
                    case ConsoleKey.X: valid=true; return Character.CharacterRace.Gnoll;
                    default: valid=false; Console.WriteLine("Invalid Choice"); return CharacterRace.InvalidChoice;
                }
            } while (valid==false);
        }



    }
}