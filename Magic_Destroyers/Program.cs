using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_Destroyers.Assets.Equipment;
using Magic_Destroyers.Assets.Characters.Melee;
using Magic_Destroyers.Assets.Characters.Spellcasters;

namespace Magic_Destroyers
{
    class Program
    {
        static void Main()
        {
            Warrior warrior1 = new Warrior("Good Guy Greg");
            warrior1.Weapon = new Axe();
            warrior1.BodyArmor = new Chainlink();

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

            Console.WriteLine($"{mage1.Weapon} damage points: {mage1.Weapon.Damage}");
            Console.WriteLine($"{neutralGuy.Weapon} damage points: {neutralGuy.Weapon.Damage}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
