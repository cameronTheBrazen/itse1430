namespace Cameron.CharacterCreator
{
    public class Character
    {
        public enum CharacterRace
        {
            Dwarf=1,
            Elf=2,
            Gnome=3,
            Human=4,
            Gnoll=5
        };
        public enum characterClass
        {
            Paladin=1,
            Cleric=2,
            Warrior=3,
            Rogue=4,
            Mage=5,
            Wizard=6,
            SpellSword=7,
            ShieldWarden=8
        };
        private int strength = 1;
        public int Strength { get { return strength; } set { strength = value; } }
        private int intelligence = 1;   
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        private int defense = 1;
        private int agility = 1;
        private int constitution = 1;
        private int charisma = 1;

       

        private void PaladinBase () { }

        






    }
}