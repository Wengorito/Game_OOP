using Assets.Equipment.Armors;
using Assets.Equipment.Armors.Heavy;
using Assets.Equipment.Weapons;
using Assets.Equipment.Weapons.Blunt;
using Enumerations;

namespace Assets.Characters.Melees
{
    class Knight : Melee
    {
        private const string DEFAULT_NAME = "Knajt";

        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();


        public Hammer Weepone { get; set; }

        public Knight(string name = DEFAULT_NAME) : this(name, Faction.Melee)
        {

        }

        public Knight(string name, Faction faction) : this(name, faction, DEFAULT_LEVEL)
        {

        }

        public Knight(string name, Faction faction, int level) : base(name, faction, level)
        {
            this.Weepone = DEFAULT_WEAPON;
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
