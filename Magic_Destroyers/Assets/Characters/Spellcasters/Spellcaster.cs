using Assets.Characters.Melees;
using Assets.Equipment.Spells;
using Enumerations;
using Magic_Destroyers.Interfaces;
using System;

namespace Assets.Characters.Spellcasters
{
    abstract class Spellcaster : Character, ISpellcaster
    {
        //private const int DEFAULT_HEALTHPOINTS = 100;
        //protected new const int MIN_AGE = 30;

        public override int Age
        {
            get => base._age;

            set
            {
                if (value > Consts.Spellcaster.MIN_AGE)
                    base._age = value;
                else
                    throw new ArgumentNullException(string.Empty, $"Spellcaster's age must be greater than {Consts.Spellcaster.MIN_AGE}");
            }
        }

        public Spell MySpell 
        { 
            get;
            set;
        }
        public int Mana
        {
            get;
            set;
        }

        public Spellcaster(string name, Faction faction, int level) : base(name, faction, level)
        {
            base.HealthPoints = Consts.Spellcaster.HEALTHPOINTS;
        }

        public void CastSpell(Melee character)
        {
            character.HealthPoints -= MySpell.Damage;
            this.Mana -= MySpell.ManaCost;
        }
    }
}
