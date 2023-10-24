using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameron.AdventureGame.WinHost
{
    internal class Creator
    {
        public Creator()
        {
            public void SetClassStats()
            {
                if (Character.CharacterClass.Paladin)
                {
                    PaladinBase();
                }
                else if (SelectedClass == CharacterClass.Cleric)
                {
                    ClericBase();
                }
                else if (SelectedClass == CharacterClass.Warrior)
                {
                    WarriorBase();
                }
                else if (SelectedClass == CharacterClass.Mage)
                {
                    MageBase();
                }
                else if (SelectedClass == CharacterClass.Wizard)
                {
                    WizardBase();
                }
                else if (SelectedClass == CharacterClass.SpellSword)
                {
                    SpellSwordBase();
                }
                else if (SelectedClass == CharacterClass.ShieldWarden)
                {
                    ShieldWardenBase();
                }
            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void PaladinBase()
            {
                Strength = 60;
                Intelligence = 60;
                Defense = 80;
                Agility = 10;
                Constitution = 50;
                Charisma = 40;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void ClericBase()
            {
                Strength = 40;
                Intelligence = 70;
                Defense = 80;
                Agility = 10;
                Constitution = 50;
                Charisma = 50;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void WarriorBase()
            {
                Strength = 100;
                Intelligence = 10;
                Defense = 80;
                Agility = 20;
                Constitution = 50;
                Charisma = 40;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void RogueBase()
            {
                Strength = 10;
                Intelligence = 60;
                Defense = 50;
                Agility = 90;
                Constitution = 50;
                Charisma = 40;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void MageBase()
            {
                Strength = 10;
                Intelligence = 100;
                Defense = 10;
                Agility = 80;
                Constitution = 20;
                Charisma = 80;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void WizardBase()
            {
                Strength = 10;
                Intelligence = 100;
                Defense = 10;
                Agility = 20;
                Constitution = 80;
                Charisma = 80;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void SpellSwordBase()
            {
                Strength = 10;
                Intelligence = 100;
                Defense = 10;
                Agility = 80;
                Constitution = 20;
                Charisma = 80;


            }
            /// <summary>
            /// Sets base stats 
            /// </summary>
            private void ShieldWardenBase()
            {
                Strength = 40;
                Intelligence = 40;
                Defense = 70;
                Agility = 40;
                Constitution = 70;
                Charisma = 40;


            }
            /// <summary>
            /// method for character name creation
            /// </summary>
            /// <returns></returns>
            public string CreateName()
            {


                return CharacterName;
            }


            /// <summary>
            /// free status point validation
            /// </summary>
            private void CalcPoints()
            {
                FreeStatusPoints = 300 - Strength - Intelligence - Defense - Agility - Constitution - Charisma;




            }


            /// <summary>
            /// method to delete character
            /// </summary>
            public void DeleteCharacter()
            {
                CharacterName = "";
                SelectedRace = (CharacterRace)0;
                SelectedClass = (CharacterClass)0;
                Strength = 0;
                Intelligence = 0;
                Defense = 0;
                Agility = 0;
                Constitution = 0;
                Charisma = 0;

            }


        public override string ToString()
        {
            return $"{CharacterName} [{SelectedRace}] [{SelectedClass}]";
        }

        /// <summary>
        /// validates a character instance
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override bool TryValidate(out string message)
        {

            if (String.IsNullOrEmpty(CharacterName))
            {
                message = "Name is required!";
                return false;
            }
            if (SelectedRace == 0)
            {

                message = " Invalid Race Choice";
                return false;
            }
            if (SelectedClass == 0)
            {
                message = "Invalid Class Choice";
                return false;
            }


            message = "";
            return true;

        }
        /// <summary>
        /// creates a random class and race character still requires name.
        /// </summary>
        public void RandomToon()
        {
            var random = new Random();

            SelectedRace = RandomEnumValue<CharacterRace>(random);
            SelectedClass = RandomEnumValue<CharacterClass>(random);
            SetClassStats();

        }

        private static T RandomEnumValue<T>(Random random)
        {
            var v = CharacterRace.GetValues(typeof(T));
            var _R = random;
            return (T)v.GetValue(_R.Next(v.Length));
        }
    }
}
}
