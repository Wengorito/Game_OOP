using Enumerations;
using System;

namespace Assets.Characters.Melees
{
    abstract class Melee : Character
    {
        private const int DEFAULT_HEALTHPOINTS = 200;
        private const int MAX_AGE = 60;

        private int _staminaPoints;
        public int StaminaPoints
        {
            get { return _staminaPoints; }
            set { _staminaPoints = value; }
        }

        public override int Age
        {
            get => base._age;

            set
            {
                if (value < MAX_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Melee characters age must be between {MIN_AGE} and {MAX_AGE}");
            }
        }

        public Melee(string name, Faction faction, int level) : base(name, faction, level)
        {
            HealthPoints = DEFAULT_HEALTHPOINTS;            
        }
    }
}
