using System;

namespace Assets.Equipment.Weapons
{
    public abstract class Weapon
    {
        private int _damagePoints;

        public int DamagePoints 
        { 
            get { return _damagePoints; }
            set
            {
                if (value >= 0)
                    _damagePoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage Points value should be a positive number");
            }
        }
    }
}