using Enumerations;
using System;

namespace Assets.Characters.Spellcasters
{
    abstract class Spellcaster : Character
    {
        private const int DEFAULT_HEALTHPOINTS = 100;
        protected const int MIN_AGE = 30;

        public override int Age
        {
            get => base.Age;

            set
            {
                if (value > MIN_AGE)
                    base.Age = value;
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
