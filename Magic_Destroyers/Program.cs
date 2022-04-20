using System;
using System.Collections.Generic;
using Assets.Characters;
using Assets.Characters.Melees;
using Assets.Characters.Spellcasters;
using Assets.Equipment.Armors.Heavy;
using Assets.Equipment.Armors.Leather;
using Assets.Equipment.Armors.Light;
using Assets.Equipment.Weapons.Blunt;
using Assets.Equipment.Weapons.Sharp;
using Enumerations;

namespace Magic_Destroyers
{
    class Program
    {
        static void Main()
        {
            List<Character> characters = new List<Character>
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                new Mage(),
                new Mage(),
                new Mage()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach(Character character in characters)
            {
                if(character is Melee)
                    meleeTeam.Add(character as Melee);
                
                else if(character is Spellcaster)
                    spellTeam.Add(character as Spellcaster);
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
