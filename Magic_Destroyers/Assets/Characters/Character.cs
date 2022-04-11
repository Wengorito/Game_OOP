using Assets.Equipment;
using Enumerations;
using System;

namespace Assets.Characters
{
    abstract public class Character
    {
        public const int DEFAULT_ABILITYPOINTS = 100;
        public const int DEFAULT_HEALTHPOINTS_BADGUY = 100;
        public const int DEFAULT_HEALTHPOINTS_GOODGUY = 120;
        public const int DEFAULT_LEVEL = 1;

        private readonly int _id;

        private static int _idCounter;

        private string _name;
        private int _abilityPoints;
        private int _healthPoins;
        private int _level;
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

        //abilities
        public void Greet(Character character)
        {
            Console.WriteLine($"Elo {character.Name} (myself), inhertied member");
        }
        public Character(string name = "Noname", Faction faction = Faction.Default)
        {
            _idCounter++;
            _id = _idCounter;
            _faction = faction;
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
    }
}
