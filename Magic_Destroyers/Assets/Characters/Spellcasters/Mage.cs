using System;
using Assets.Equipment.Armors.Light;
using Assets.Equipment.Weapons;
using Assets.Equipment.Weapons.Blunt;
using Enumerations;

namespace Assets.Characters.Spellcasters
{
    class Mage : Spellcaster
    {
        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        public Mage (string name = Consts.Mage.NAME) : base(name, Faction.Spellcaster, Consts.LEVEL)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }

        public override int Age
        {
            get => base._age;

            set
            {
                if (value > Consts.Mage.MIN_AGE && value < Consts.Mage.MAX_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Mage's age must be between {Consts.Mage.MIN_AGE} and {Consts.Mage.MAX_AGE}");
            }
        }

        public int ArcaneWrath()
        {
            return Weapon.DamagePoints + 10;
        }
        public int Firewall()
        {
            return Weapon.DamagePoints + 20;
        }
        public int Meditation()
        {
            return BodyArmor.ArmorPoints + 5;
        }
        public void Curse(Character character)
        {
            Console.WriteLine($"Damn you, {character.Name}!");
        }

        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return Firewall();
        }

        public override int Defend()
        {
            return Meditation();
        }
    }
}
