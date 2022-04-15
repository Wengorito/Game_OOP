﻿using System;
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
            Warrior warrior1 = new Warrior("Good Guy Greg", Faction.Melee, 1);
            Warrior warrior2 = new Warrior("Todd", Faction.Melee);
            Warrior warrior3 = new Warrior();

            Knight knight1 = new Knight();
            knight1.Weapon = new Hammer();
            knight1.BodyArmor = new Chainlink();

            Assessin assessin1 = new Assessin();
            assessin1.Weapon = new Sword();
            assessin1.BodyArmor = new LightLeatherVest();

            Mage mage1 = new Mage("Scumbag Steve")
            {
                BodyArmor = new ClothRobe(),
                Weapon = new Staff()
            };

            Necromancer necro1 = new Necromancer("Necrophos")
            {
                BodyArmor = new LightLeatherVest(),
                Weapon = new Sword()
            };

            Druid neutralGuy = new Druid("Drut")
            {
                BodyArmor = new LightLeatherVest(),
                Weapon = new Staff()
            };

            Console.WriteLine($"Hi my name is {warrior1.Name} and I have {warrior1.HealthPoints} HP points hahaha");

            warrior1.Greet(mage1);
            mage1.Curse(warrior1);
            Console.WriteLine(neutralGuy.Name);

            Console.WriteLine(warrior1.AbilityPoints);
            warrior1.AbilityPoints *= 2;
            Console.WriteLine(warrior1.AbilityPoints);

            Console.WriteLine($"{warrior1.Weapon} damage points: {warrior1.Weapon.DamagePoints}");
            Console.WriteLine($"{neutralGuy.Weapon} damage points: {neutralGuy.Weapon.DamagePoints}");

            Console.WriteLine($"First character {warrior1.Name} HP: {warrior1.HealthPoints}\n" +
                $"Second character {warrior2.Name} HP: {warrior2.HealthPoints}\n" +
                $"Third character {warrior3.Name} HP: {warrior3.HealthPoints}\n");

            try
            {
                warrior1.Age = 18;
                knight1.Age = 30;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"knight1 age: {knight1.Age}");
            Console.WriteLine($"warrior1 age: {warrior1.Age}");

            Console.WriteLine(warrior1.HealthPoints);
            Console.WriteLine(warrior2.HealthPoints);
            Console.WriteLine(warrior3.HealthPoints);

            Console.WriteLine(warrior1.BodyArmor);
            warrior1.BodyArmor = new LightLeatherVest();
            Console.WriteLine(warrior1.BodyArmor);

            Console.WriteLine(knight1.Weapon);
            Console.WriteLine(knight1.Weapon.DamagePoints);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
