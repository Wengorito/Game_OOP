using Assets.Equipment;
using Enumerations;
using System;

namespace Assets.Characters.Melee
{
    public class Warrior : Character
    {
        private readonly Weapon DEFAULT_WEAPON = new Axe();
        private readonly Armor DEFAULT_ARMOR = new Chainlink();
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

        public Warrior(string name, Faction faction = Faction.GoodGuy) : base(name, faction)
        {
            base.Greet(this);
            Greet(this);
        }

        public Warrior() : this("Basic Warrior", DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level) : this(Faction.Default, name, level)
        {
        }

        public Warrior(Faction faction, string name, int level) : base(name, faction)
        {
            this.Faction = faction;
            this.Level = level;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_ARMOR;
        }
    }


}
