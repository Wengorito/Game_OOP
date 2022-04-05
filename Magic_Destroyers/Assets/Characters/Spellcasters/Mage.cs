using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Assets.Characters.Spellcasters
{
    class Mage : Character
    {
        public Mage (string name = "") : base(name)
        {

        }
        public void ArcaneWrath()
        {

        }
        public void Firewall()
        {

        }
        public void Meditation()
        {

        }
        public void Curse(Character character)
        {
            Console.WriteLine($"Damn you, {character.Name}!");
        }
    }
}
