// Cameron kingsley
//9/23/2023
//ITSE1430
using System;

namespace Cameron.AdventureGame
{
    public class Character : ValidatableObject
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
        private string _characterName = "";
        /// <summary>
        /// Character's Name
        /// </summary>
        public string CharacterName { get; set; }
        private Character.CharacterRace _selectedRace;
        /// <summary>
        /// Character race
        /// </summary>
        public CharacterRace SelectedRace { get => _selectedRace; set => _selectedRace=value; }
        private Character.CharacterClass _selectedClass;
        /// <summary>
        /// Character class
        /// </summary>
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

        private int _freeStatusPoints = 0;
        /// <summary>
        /// available status points to edit character
        /// </summary>
        public int FreeStatusPoints { get; set; }

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
        /// <summary>
        /// method for character name creation
        /// </summary>
        /// <returns></returns>
        public string CreateName ()
        {
            bool nullName = true;
            while (nullName==true)
            {
                Console.WriteLine(" Enter Your Characters Name ");
                CharacterName= Console.ReadLine();
                if (String.IsNullOrEmpty(CharacterName))
                {

                    nullName= true;
                } else
                {
                    nullName= false;
                }
            }


            return CharacterName;
        }
        /// <summary>
        /// method for class selection
        /// </summary>
        public void SelectClass ()
        {
            bool valid = false;
            // add character; quit; 
            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.P: valid=true; SelectedClass= Character.CharacterClass.Paladin; PaladinBase(); break;
                    case ConsoleKey.C: valid=true; SelectedClass= Character.CharacterClass.Cleric; ClericBase(); break;
                    case ConsoleKey.W: valid=true; SelectedClass= Character.CharacterClass.Warrior; WarriorBase(); break;
                    case ConsoleKey.R: valid=true; SelectedClass= Character.CharacterClass.Rogue; RogueBase(); break;
                    case ConsoleKey.M: valid=true; SelectedClass= Character.CharacterClass.Mage; MageBase(); break;
                    case ConsoleKey.Z:
                    valid=true;
                    SelectedClass= Character.CharacterClass.Wizard; WizardBase(); break;
                    case ConsoleKey.S:
                    valid=true;
                    SelectedClass= Character.CharacterClass.SpellSword; SpellSwordBase(); break;
                    case ConsoleKey.D: valid=true; SelectedClass= Character.CharacterClass.ShieldWarden; ShieldWardenBase(); break;
                    default: valid=false; Console.WriteLine("Invalid Choice"); SelectedClass= Character.CharacterClass.InvalidChoice; break;


                }
            } while (valid==false);
        }

        /// <summary>
        /// method for race selection
        /// </summary>
        public void SelectRace ()
        {

            bool valid;
            do
            {
                // add character; quit; 
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D: valid=true; SelectedRace= Character.CharacterRace.Dwarf; break;
                    case ConsoleKey.E: valid=true; SelectedRace= Character.CharacterRace.Elf; break;
                    case ConsoleKey.G: valid=true; SelectedRace= Character.CharacterRace.Gnome; break;
                    case ConsoleKey.H: valid=true; SelectedRace= Character.CharacterRace.Human; break;
                    case ConsoleKey.X: valid=true; SelectedRace= Character.CharacterRace.Gnoll; break;
                    default: valid=false; Console.WriteLine("Invalid Choice"); SelectedRace= Character.CharacterRace.InvalidChoice; break;
                }
            } while (valid==false);
        }
        /// <summary>
        /// method to reduce status points on selected stat
        /// </summary>
        /// <param name="backingUp"></param>
        public void ReduceStats ( bool backingUp )
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.S: if (Strength>=10) { Strength=Strength- 10; break; } else { break; }
                case ConsoleKey.I: if (Intelligence>=10) { Intelligence=Intelligence- 10; break; } else { break; }
                case ConsoleKey.D: if (Defense>=10) { Defense=Defense- 10; break; } else { break; }
                case ConsoleKey.A: if (Agility>=10) { Agility=Agility- 10; break; } else { break; }
                case ConsoleKey.C: if (Constitution>=10) { Constitution=Constitution- 10; break; } else { break; }
                case ConsoleKey.M: if (Charisma>=10) { Charisma=Charisma- 10; break; } else { break; }
                case ConsoleKey.Q: backingUp = true; break;
            }

            CalcPoints();

        }

        /// <summary>
        /// free status point validation
        /// </summary>
        private void CalcPoints ()
        {
            FreeStatusPoints= 300- Strength- Intelligence- Defense-Agility-Constitution- Charisma;




        }

        /// <summary>
        /// method to increase status points on selected stat
        /// </summary>
        /// <param name="backingUp"></param>
        public void IncreaseStats ( bool backingUp )
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.S: if (Strength<=90) { Strength=Strength+ 10; break; } else { break; }
                case ConsoleKey.I: if (Intelligence<=90) { Intelligence=Intelligence+ 10; break; } else { break; }
                case ConsoleKey.D: if (Defense<=90) { Defense=Defense+ 10; break; } else { break; }
                case ConsoleKey.A: if (Agility<=90) { Agility=Agility+ 10; break; } else { break; }
                case ConsoleKey.C: if (Constitution<=90) { Constitution=Constitution+ 10; break; } else { break; }
                case ConsoleKey.M: if (Charisma<=90) { Charisma=Charisma+ 10; break; } else { break; }
                case ConsoleKey.Q: backingUp = true; break;
            }


        }
        /// <summary>
        /// method to delete character
        /// </summary>
        public void DeleteCharacter ()
        {
            CharacterName="";
            SelectedRace=0;
            SelectedClass=0;
            Strength=0;
            Intelligence=0;
            Defense= 0;
            Agility=0;
            Constitution= 0;
            Charisma=0;

        }
        
        public override string ToString ()
        {
            return $"{CharacterName } [{SelectedRace}] [{SelectedClass}]";
        }

        /// <summary>
        /// validates a character instance
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool TryValidate ( out string message )
        {

            if (String.IsNullOrEmpty(CharacterName))
            {
                message = "Name is required!";
                return false;
            }
            if (SelectedRace==0)
            {

                message= " Invalid Race Choice";
                return false;
            }
            if (SelectedClass==0 )
            {
                message= "Invalid Class Choice";
                return false;
            }

            
            message="";
            return true;

        }
        /// <summary>
        /// creates a random class and race character still requires name.
        /// </summary>
        public void RandomToon ()
        {

        }
    }
}