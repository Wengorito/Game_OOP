using Assets.Equipment;
using Enumerations;
using System;

namespace Assets.Characters.Spellcasters
{
    class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Drut";
        private const int MAX_AGE = 70;

        private readonly Weapon DEFAULT_WEAPON = new Sword();
        private readonly Armor DEFAULT_ARMOR = new LightLeatherVest();

        public Druid(string name = DEFAULT_NAME) : base(name, Faction.GoodGuy, DEFAULT_LEVEL)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }
        public override int Age
        {
            get => base.Age;

            set
            {
                if (value > MIN_AGE && value < MAX_AGE)
                    base.Age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Druid's age must be between {MIN_AGE} and {MAX_AGE}");
            }
        }
        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithTheNature()
        {

        }
    }
}
