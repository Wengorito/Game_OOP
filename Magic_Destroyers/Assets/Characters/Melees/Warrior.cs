using Assets.Equipment.Armors.Heavy;
using Assets.Equipment.Weapons.Sharp;
using Enumerations;
using System;

namespace Assets.Characters.Melees
{
    public class Warrior : Melee
    {
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();

        public override int Age 
        { 
            get => base._age;

            set
            {
                if (value < Consts.Warrior.MAX_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Warrior's age must be between {Consts.MIN_AGE} and {Consts.Warrior.MAX_AGE}");
            }
        }

        //ctors
        public Warrior() : this(Consts.Warrior.NAME)
        {

        }
        public Warrior(string name) : this(name, Faction.Melee)
        {
            base.Greet(this);
            Greet(this);
        }

        public Warrior(string name, Faction faction) 
            : this(name, faction, Consts.LEVEL)
        {
        }

        public Warrior(string name, Faction faction, int level) 
            : base(name, faction, level)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }

        //methods
        public override void Greet(Character character)
        {
            Console.WriteLine($"Elo {character.Name}, child member");
        }
        public void SpecialWarriorGreeting()
        {
            Console.WriteLine("I is a Warrior!");
            base.Greet(this);
        }
        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Warrior");
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public int Execute()
        {
            return base.Weapon.DamagePoints + 20;
        }
        public int SkinHarden()
        {
            return BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return Strike();
        }

        public override int SpecialAttack()
        {
            return Execute();
        }

        public override int Defend()
        {
            return SkinHarden();
        }
    }


}
