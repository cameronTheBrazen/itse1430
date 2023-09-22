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
        private int _strength = 1;
        public int Strength { get { return _strength; } set { _strength = value; } }
        private int _intelligence = 1;   
        public int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        private int _defense = 1;
        public int Defense { get { return _defense; } set { _defense = value; } }
        private int agility = 1;
        private int constitution = 1;
        private int charisma = 1;

       

        private void PaladinBase () { }

        






    }
}