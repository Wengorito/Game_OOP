using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Assets.Equipment
{
    abstract public class Armor
    {
        int _armorPoints;
        public int ArmorPoints { get; set; }

    }
    class Chainlink : Armor
    {
        public Chainlink()
        {
            ArmorPoints = 100;
        }

    }
    class LightLeatherVest : Armor
    {
        public LightLeatherVest()
        {
            ArmorPoints = 50;
        }
    }
    class ClothRobe : Armor
    {
        public ClothRobe()
        {
            ArmorPoints = 25;
        }
    }
}
