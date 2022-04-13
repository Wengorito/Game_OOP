namespace Assets.Equipment
{
    abstract public class Weapon
    {
        private int _damage;

        public int Damage 
        { 
            get { return _damage; } 
            protected set { _damage = value > 0 ? value : 1; }
        }
    }
    class Sword : Weapon
    {
        private const int DEFAULT_DAMAGE = 15;
        public Sword()
        {
            Damage = DEFAULT_DAMAGE;
        }
        public void Bloodthirst()
        {

        }
    }

    class Axe : Weapon
    {
        private const int DEFAULT_DAMAGE = 20;

        public Axe()
        {
            Damage = DEFAULT_DAMAGE;
        }
        public void HackNSlash()
        {

        }

    }
    class Hammer : Weapon
    {
        private const int DEFAULT_DAMAGE = 10;

        public Hammer()
        {
            Damage = DEFAULT_DAMAGE;
        }
        public void Stun()
        {

        }

    }

    class Staff : Weapon
    {
        private const int DEFAULT_DAMAGE = 5;

        public Staff()
        {
            Damage = DEFAULT_DAMAGE;
        }
        public void Empower()
        {

        }
    }
}
