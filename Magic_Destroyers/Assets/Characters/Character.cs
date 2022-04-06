using Magic_Destroyers.Assets.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Assets.Characters
{
    abstract public class Character
    {
        public Character(string name = "")
        {
            Name = name;
            Greet(this);
        }

        private string _name;
        private int _abilityPoints;
        private string _faction;
        private int _healthPoins;
        private int _level;
        private dynamic _bodyArmor;
        private Weapon _weapon;
        public string Name
        {
            //get { return _name; }
            get 
            {
                if (String.IsNullOrEmpty(_name))
                    return "Noname"; 
                else
                    return _name;
            }
            set
            {
                _name = String.IsNullOrEmpty(value) ? "Noname" : value;
            }
        }
        public int AbilityPoints
        {
            get { return _abilityPoints; }
            set
            {
                _abilityPoints = value > 0 ? value : 0; //zero or less -> 0
            }
        }
        public string Faction 
        {
            get { return _faction; }
            set
            {
                _faction = (String.Equals("Melee", value) || String.Equals("Spellcaster", value)) ? value : "";
            }
        }
        public int HealthPoints 
        {
            get { return _healthPoins; } 
            set
            {
                _healthPoins = value > 0 ? value : 0;
            }
        }
        public int Level 
        { 
            get { return _level; }
            set { _level = value > 0 ? value : 0; } 
        }
        public dynamic BodyArmor
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
        public virtual void OffensiveAbility1()
        {

        }
        public virtual void OffensiveAbility2()
        {

        }
        public virtual void DeffensiveAbility1()
        {

        }
    }
}
