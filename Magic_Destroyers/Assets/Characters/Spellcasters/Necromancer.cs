using Assets.Equipment;
using Enumerations;
using System;

namespace Assets.Characters.Spellcasters
{
    class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necro";
        private const int MAX_AGE = 150;
        private const int MIN_AGE = 50;

        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly Armor DEFAULT_ARMOR = new LightLeatherVest();
        public Necromancer(string name = DEFAULT_NAME) : base(name, Faction.BadGuy, DEFAULT_LEVEL)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }
        public override int Age
        {
            get => base.Age;

            set
            {
                if (value > 20 && value < 60)
                    base.Age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Druid's age must be between {MIN_AGE} and {MAX_AGE}");
            }
        }
        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneShield()
        {

        }
    }
}
