using Assets.Equipment;
using Enumerations;
using System;

namespace Assets.Characters.Melees
{
    class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Barb";
        private const int MAX_AGE = 30;

        private readonly Weapon DEFAULT_WEAPON = new Axe();
        private readonly Armor DEFAULT_ARMOR = new Chainlink();

        public override int Age 
        { 
            get => base._age;

            set
            {
                if (value < MAX_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Warrior's age must be between {MIN_AGE} and {MAX_AGE}");
            }
        }

        //abilities
        public void Strike()
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {

        }
        public void SkinHarden()
        {

        }
        public new void Greet(Character character)
        {
            Console.WriteLine($"Elo {character.Name}, child member");
        }

        //ctors

        public Warrior() : this(DEFAULT_NAME)
        {

        }
        public Warrior(string name) : this(name, Faction.GoodGuy)
        {
            base.Greet(this);
            Greet(this);
        }

        public Warrior(string name, Faction faction) 
            : this(name, faction, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, Faction faction, int level) 
            : base(name, faction, level)
        {
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }

        //methods
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
    }


}
