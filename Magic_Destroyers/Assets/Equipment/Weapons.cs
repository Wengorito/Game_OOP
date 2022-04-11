namespace Assets.Equipment
{
    abstract public class Weapon
    {
        private int _damage;
        //public int Damage => _damage;
        //the above is equivalent of
        public int Damage 
        { 
            get { return _damage; } 
            internal set { _damage = value > 0 ? value : 1; }
        }
    }
    class Sword : Weapon
    {
        public Sword()
        {
            Damage = 15;
        }
        public void Bloodthirst()
        {

        }
    }

    class Axe : Weapon
    {
        public Axe()
        {
            Damage = 20;
        }
        public void HackNSlash()
        {

        }

    }
    class Hammer : Weapon
    {
        public Hammer()
        {
            Damage = 10;
        }
        public void Stun()
        {

        }

    }

    class Staff : Weapon
    {
        public Staff()
        {
            Damage = 5;
        }
        public void Empower()
        {

        }
    }
}
