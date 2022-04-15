
using System;

namespace Assets.Equipment.Armors
{
    public abstract class Armor
    {
        private int _armorPoints;
        public int ArmorPoints
        {
            get { return _armorPoints; }

            set
            {
                if (value >= 0)
                {
                    this._armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }
    }
}
