
using Assets.Equipment;
using Enumerations;

namespace Assets.Characters.Melees
{
    class Knight : Melee
    {
        private const string DEFAULT_NAME = "Knajt";

        private readonly Weapon DEFAULT_WEAPON = new Hammer();
        private readonly Armor DEFAULT_ARMOR = new Chainlink();

        public Knight(string name = DEFAULT_NAME) : this(name, Faction.GoodGuy)
        {

        }

        public Knight(string name, Faction faction) : this(name, faction, DEFAULT_LEVEL)
        {

        }

        public Knight(string name, Faction faction, int level) : base(name, faction, level)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }

        //abilities
        public void HolyBlow()
        {

        }
        public void PurifySoul()
        {

        }
        public void RighteousWings()
        {

        }
        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
        public override void SpecialAttack()
        {
            throw new System.NotImplementedException();
        }
        public override void Defend()
        {
            throw new System.NotImplementedException();
        }

    }
}
