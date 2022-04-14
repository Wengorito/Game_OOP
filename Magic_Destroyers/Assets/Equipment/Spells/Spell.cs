namespace Assets.Equipment.Spells
{
    public class Spell
    {
        private int _manaCost;
        private int _damage;

        public int ManaCost
        {
            get
            {
                return this._manaCost;
            }
            set
            {
                this._manaCost = value;
            }
        }
        public int Damage
        {
            get
            {
                return this._damage;
            }
            set
            {
                this._damage = value;
            }
        }

        public Spell()
        {
            this.ManaCost = 10;
            this.Damage = 10;
        }
    }
}
