// Cameron kingsley
//9/23/2023
//ITSE1430
using System;

namespace Cameron.AdventureGame
{
    public class Character : ValidatableObject
    {
       public Character ()
        {
            CharacterName="";
            SelectedRace=(CharacterRace)0;
            SelectedClass=(CharacterClass)0;
            Strength=0;
            Intelligence=0;
            Defense= 0;
            Agility=0;
            Constitution= 0;
            Charisma=0;
        }


        public enum CharacterRace
        {
            Dwarf = 1,
            Elf = 2,
            Gnome = 3,
            Human = 4,
            Gnoll = 5,
            SelectNew=0
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
           SelectNew=0
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
        public int FreeStatusPoints { get { return 300- Strength- Intelligence- Defense-Agility-Constitution- Charisma; } }
        public object DataSource { get; internal set; }
        public void SetClassStats ()
        {
            if (SelectedClass==CharacterClass.Paladin) {
                PaladinBase();
            }
            else if(SelectedClass==CharacterClass.Cleric) {
                ClericBase();
            } else if (SelectedClass==CharacterClass.Warrior)
            {   WarriorBase();
            } else if (SelectedClass==CharacterClass.Mage)
            {MageBase();
            } else if (SelectedClass==CharacterClass.Wizard)
            {
                WizardBase();
            } else if (SelectedClass==CharacterClass.SpellSword)
            {SpellSwordBase();
            } else if (SelectedClass==CharacterClass.ShieldWarden)
            {ShieldWardenBase();
            }
        }
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
           

            return CharacterName;
        }
        

        
        
        
        /// <summary>
        /// method to delete character
        /// </summary>
        public void DeleteCharacter ()
        {
            CharacterName="";
            SelectedRace=(CharacterRace)1;
            SelectedClass=(CharacterClass)1;
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
        
       
    }
}