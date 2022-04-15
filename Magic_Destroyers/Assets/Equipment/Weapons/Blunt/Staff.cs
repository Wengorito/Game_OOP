using System;

namespace Assets.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE = 5;

        public Staff()
            : this(DEFAULT_DAMAGE)
        {
        }

        public Staff(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
