using Assets.Characters.Interfaces; //jakim cudem to nie daje errora
using Assets.Equipment.Weapons;
using Assets.Equipment.Armors;
using Enumerations;
using System;
using System.Threading;

namespace Assets.Characters
{
    abstract public class Character : IAttack, IDefend
    {
        private readonly int _id;

        private static int _idCounter;

        private bool _isAlive = true;
        private string _name;
        private int _abilityPoints;
        private int _healthPoints;
        //private int _scores;
        private int _level;
        protected int _age;
        private Faction _faction;
        private Armor _bodyArmor;
        private Weapon _weapon;

        public int Id
        {
            get { return _id; }
        }

        public bool IsAlive 
        {
            get { return _isAlive; }
            private set { _isAlive = value; }
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
            get { return _healthPoints; } 
            set
            {
                //_healthPoints = value > 0 ? value : 0;
                if (value >= 0)
                    _healthPoints = value;
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health Points cannot be negative");
                }
            }
        }
        public int Scores { get; set; } = 0;//not necessary since its zero by default
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
                if (value >= Consts.MIN_AGE)
                    _age = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, $"Character's age must be greater than {Consts.MIN_AGE}");
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
            _abilityPoints = Consts.ABILITYPOINTS;

            Name = name;
            Greet(this);
        }

        //abilities
        public virtual void Greet(Character character)
        {
            Console.WriteLine($"Elo {character.Name} (myself), base class");
        }

        public virtual void Move(int pauseBetweenMoves)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving!");
                Thread.Sleep(pauseBetweenMoves);
            }
        }

        public abstract int Attack();
        public abstract int SpecialAttack();
        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                _healthPoints -= damage - this.Defend();

                if(_healthPoints <= 0)
                {
                    _isAlive = false;                    
                }
            }
            else
            {
                Console.WriteLine("Haha! You cannot harm me!");
            }

            if(!this._isAlive)
            {
                Console.WriteLine($"{this.Name} received {damage - Defend()} damage from {attackerName}, and is now dead!");
            }
            else
            {
                Console.WriteLine($"{this.Name} received {damage - Defend()} damage from {attackerName}, and is still alive!");
            }
        }

        public void WonBattle()
        {
            Scores++;

            if(Scores % 10 == 0)
            {
                Level++;
            }
        }
    }
}
