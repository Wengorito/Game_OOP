using System;

namespace Assets.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE = 20;

        public Axe()
            : this(DEFAULT_DAMAGE)
        {
        }

        public Axe(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public void HackNSlash()
        {
            Console.WriteLine("This is special attack of axe - Hack n Slash");
        }
    }
}
