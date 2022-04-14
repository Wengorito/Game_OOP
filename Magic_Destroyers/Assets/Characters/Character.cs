using Assets.Characters.Interfaces; //jakim cudem to nie daje errora
using Assets.Equipment;
using Enumerations;
using System;
using System.Threading;

namespace Assets.Characters
{
    abstract public class Character : IAttack, IDefend
    {
        private const int DEFAULT_ABILITYPOINTS = 100;
        private const int DEFAULT_HEALTHPOINTS_BADGUY = 100;
        private const int DEFAULT_HEALTHPOINTS_GOODGUY = 120;
        protected const int MIN_AGE = 18;
        protected const int DEFAULT_LEVEL = 1;

        private readonly int _id;

        private static int _idCounter;

        private string _name;
        private int _abilityPoints;
        private int _healthPoins;
        private int _level;
        protected int _age;
        private Faction _faction;
        private Armor _bodyArmor;
        private Weapon _weapon;

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get 
            {
                if (String.IsNullOrEmpty(_name))
                    return "Noname"; 
                else
                    return this._name;
            }
            set
            {
                this._name = String.IsNullOrEmpty(value) ? "Noname" : value;
            }
        }
        public int AbilityPoints
        {
            get { return _abilityPoints; }
            internal set
            {
                _abilityPoints = value > 0 ? value : 0; //zero or less -> 0
            }
        }
        public Faction Faction 
        {
            get { return _faction; }
            set { _faction = value; }
        }
        public int HealthPoints 
        {
            get { return _healthPoins; } 
            set
            {
                //_healthPoins = value > 0 ? value : 0;
                if (value >= 0)
                    _healthPoins = value;
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health Points cannot be negative");
                }
            }
        }
        public int Level 
        { 
            get { return _level; }
            set { _level = value > 0 ? value : 0; } 
        }
        public virtual int Age
        {
            get { return _age; }
            set 
            {
                if (value >= MIN_AGE)
                    _age = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, $"Character's age must be greater than {MIN_AGE}");
            }
        }
        public Armor BodyArmor
        {
            get { return _bodyArmor; } 
            set { _bodyArmor = value; }
        }
        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public Character()
        {

        }
        public Character(string name, Faction faction, int level)
        {
            _idCounter++;
            _id = _idCounter;
            _faction = faction;
            _level = level;
            _abilityPoints = DEFAULT_ABILITYPOINTS;
            if (faction == Faction.GoodGuy)
            {
                _healthPoins = DEFAULT_HEALTHPOINTS_GOODGUY;
            }
            else if (faction == Faction.BadGuy)
            {
                _healthPoins = DEFAULT_HEALTHPOINTS_BADGUY;
            }

            Name = name;
            Greet(this);
        }

        //abilities
        protected void Greet(Character character)
        {
            Console.WriteLine($"Elo {character.Name} (myself), inhertied member");
        }

        public virtual void Move(int pauseBetweenMoves)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving!");
                Thread.Sleep(pauseBetweenMoves);
            }
        }

        public abstract void Attack();
        public abstract void SpecialAttack();
        public abstract void Defend();
    }
}
