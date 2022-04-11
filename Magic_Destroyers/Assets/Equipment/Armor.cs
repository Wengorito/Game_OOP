using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Equipment
{
    abstract public class Armor
    {
        private int _armorPoints;
        public int ArmorPoints
        {
            get { return _armorPoints; }
            set { _armorPoints = value > 0 ? value : 1; }
        }
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
