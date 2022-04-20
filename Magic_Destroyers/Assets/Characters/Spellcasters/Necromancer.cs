//using Assets.Equipment.Armors;
//using Assets.Equipment.Armors.Leather;
//using Assets.Equipment.Weapons;
//using Assets.Equipment.Weapons.Blunt;
//using Enumerations;
//using System;

//namespace Assets.Characters.Spellcasters
//{
//    class Necromancer : Spellcaster
//    {
//        private const string DEFAULT_NAME = "Necro";
//        private const int MAX_AGE = 150;
//        private new const int MIN_AGE = 50;

//        private readonly Staff DEFAULT_WEAPON = new Staff();
//        private readonly LightLeatherVest DEFAULT_ARMOR = new LightLeatherVest(); //is it wrong to use base type?
//        public Necromancer(string name = DEFAULT_NAME) : base(name, Faction.Spellcaster, DEFAULT_LEVEL)
//        {
//            this.Weapon = DEFAULT_WEAPON;
//            this.BodyArmor = DEFAULT_ARMOR;
//        }
//        public override int Age
//        {
//            get => base.Age;

//            set
//            {
//                if (value > 20 && value < 60)
//                    base.Age = value;
//                else
//                    throw new ArgumentNullException(string.Empty, $"Druid's age must be between {MIN_AGE} and {MAX_AGE}");
//            }
//        }
//        public void ShadowRage()
//        {

//        }
//        public void VampireTouch()
//        {

//        }
//        public void BoneShield()
//        {

//        }

//        public override void Attack()
//        {
//            ShadowRage();
//        }

//        public override void SpecialAttack()
//        {
//            VampireTouch();
//        }

//        public override void Defend()
//        {
//            BoneShield();
//        }
//    }
//}
