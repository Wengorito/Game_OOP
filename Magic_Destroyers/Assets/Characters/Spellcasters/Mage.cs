using System;
using Assets.Equipment;
using Enumerations;

namespace Assets.Characters.Spellcasters
{
    class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Sorc";
        private const int MAX_AGE = 100;
        private const int MIN_AGE = 40;

        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly Armor DEFAULT_ARMOR = new ClothRobe();
        public Mage (string name = DEFAULT_NAME) : base(name, Faction.GoodGuy, DEFAULT_LEVEL)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }

        public override int Age
        {
            get => base._age;

            set
            {
                if (value > MIN_AGE && value < MAX_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Mage's age must be between {MIN_AGE} and {MAX_AGE}");
            }
        }

        public void ArcaneWrath()
        {

        }
        public void Firewall()
        {

        }
        public void Meditation()
        {

        }
        public void Curse(Character character)
        {
            Console.WriteLine($"Damn you, {character.Name}!");
        }
    }
}
