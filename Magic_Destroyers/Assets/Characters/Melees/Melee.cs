using Enumerations;
using System;

namespace Assets.Characters.Melees
{
    public abstract class Melee : Character
    {
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
                if (value < Consts.Melee.MAX_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Melee characters age must be between {Consts.MIN_AGE} and {Consts.Melee.MAX_AGE}");
            }
        }

        public Melee(string name, Faction faction, int level) : base(name, faction, level)
        {
            HealthPoints = Consts.Melee.HEALTHPOINTS;            
        }
    }
}
