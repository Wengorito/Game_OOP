namespace Assets.Equipment.Weapons.Blunt
{
    class Hammer : Blunt //is public necessary, when base class already has it?
    {
        private const int DEFAULT_DAMAGE = 10;

        public Hammer()
            : this(DEFAULT_DAMAGE)
        {
        }

        public Hammer(int damagePoints)
        {
            DamagePoints = damagePoints;
        }
        public void Stun()
        {

        }
    }
}
