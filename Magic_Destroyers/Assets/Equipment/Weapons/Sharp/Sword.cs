using Assets.Equipment.Weapons;

namespace Assets.Equipment.Weapons.Sharp
{
    class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE = 15;

        public Sword()
            : this (DEFAULT_DAMAGE)
        {
        }

        public Sword(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public void Bloodthirst()
        {

        }
    }
}
