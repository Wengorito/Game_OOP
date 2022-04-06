using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Assets.Characters.Melee
{
    class Assessin : Character
    {
        public Assessin(string name = "") : base(name)
        {

        }
        public Assessin(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
        }
        public Assessin(string name, int level) : this (name, 0, 0) { }

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
