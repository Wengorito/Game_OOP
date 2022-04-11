using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Characters.Melee
{
    class Assessin : Character
    {
        public Assessin(string name = "") : base(name)
        {

        }

        public Assessin(string name, int level) : this(name, level, 0)
        {

        }

        public Assessin(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
        }


        public void Raze()
        {

        }
        public void BleedToDeath()
        {

        }
        public void Survival()
        {

        }
    }
}
