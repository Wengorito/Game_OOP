//using Assets.Equipment.Armors;
//using Assets.Equipment.Armors.Leather;
//using Assets.Equipment.Weapons;
//using Assets.Equipment.Weapons.Sharp;
//using Enumerations;

//namespace Assets.Characters.Melees
//{
//    class Assessin : Melee
//    {
//        private const string DEFAULT_NAME = "Ass";

//        private readonly Sword DEFAULT_WEAPON_ASSESSIN = new Sword();
//        private readonly LightLeatherVest DEFAULT_ARMOR_ASSESSIN = new LightLeatherVest();

//        public Assessin() : this(DEFAULT_NAME)
//        {

//        }
//        public Assessin(string name) : this(name, Faction.Melee)
//        {

//        }

//        public Assessin(string name, Faction faction) : this(name, faction, DEFAULT_LEVEL)
//        {

//        }

//        public Assessin(string name, Faction faction, int level) : base(name, faction, level)
//        {
//            this.Weapon = DEFAULT_WEAPON_ASSESSIN;
//            this.BodyArmor = DEFAULT_ARMOR_ASSESSIN;
//        }


//        public void Raze()
//        {

//        }
//        public void BleedToDeath()
//        {

//        }
//        public void Survival()
//        {

//        }

//        public override void Attack()
//        {
//            throw new System.NotImplementedException();
//        }

//        public override void SpecialAttack()
//        {
//            throw new System.NotImplementedException();
//        }

//        public override void Defend()
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
