using Enumerations;
using System;

namespace Assets.Characters.Spellcasters
{
    abstract class Spellcaster : Character
    {
        private const int DEFAULT_HEALTHPOINTS = 100;
        protected const int MIN_AGE = 30;

        private int _manaPoints;
        public int ManaPoints 
        {
            get { return _manaPoints; } 
            set { _manaPoints = value; }
        }

        public override int Age
        {
            get => base._age;

            set
            {
                if (value > MIN_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Spellcaster's age must be greater than {MIN_AGE}");
            }
        }

        public Spellcaster(string name, Faction faction, int level) : base(name, faction, level)
        {
            base.HealthPoints = DEFAULT_HEALTHPOINTS;
        }
    }
}
