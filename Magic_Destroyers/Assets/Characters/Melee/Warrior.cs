using System;

namespace Magic_Destroyers.Assets.Characters.Melee
{
    public class Warrior : Character
    {
        public Warrior(string name = "") : base(name)
        {
            base.Greet(this);
            Greet(this);

            AbilityPoints = 1;
            Faction = "Melee";
            HealthPoints = 100;
            Level = 0;

        }
        //abilities
        public void Strike()
        {

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


    }


}
