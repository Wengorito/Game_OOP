using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Assets.Characters.Melee
{
    class Knight : Character
    {
        public Knight(string name = "") : base(name)
        {

        }

        public Knight(string name, int level) : this(name, level, 0)
        {

        }

        public Knight(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
        }

        //abilities
        public void HolyBlow()
        {

        }
        public void PurifySoul()
        {

        }
        public void RighteousWings()
        {

        }
    }
}
