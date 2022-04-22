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
            bool gameOver = false;

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

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            while(!gameOver)
            {
                Random rng = new Random();

                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count - 1)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count - 1)];

                Console.WriteLine(currentSpellcaster.HealthPoints);
                Console.WriteLine(currentMelee.HealthPoints);

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name);

                if(!currentSpellcaster.IsAlive)
                {
                    spellTeam.Remove(currentSpellcaster);
                    currentMelee.WonBattle();
                    Console.WriteLine($"Winner Warrior score: {currentMelee.Scores}, level: {currentMelee.Level}");

                    if (spellTeam.Count > 0)
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count - 1)];
                    }
                    else
                    {
                        Console.WriteLine("Melee Team has won.");
                        break;
                    }
                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name);

                if (!currentMelee.IsAlive)
                {
                    meleeTeam.Remove(currentMelee);
                    currentSpellcaster.WonBattle();
                    Console.WriteLine($"Winner Mage score: {currentSpellcaster.Scores}, level: {currentSpellcaster.Level}");

                    if (meleeTeam.Count > 0)
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count - 1)];
                    }
                    else
                    {
                        Console.WriteLine("Spellcaster Team has won.");
                        break;
                    }
                }
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
