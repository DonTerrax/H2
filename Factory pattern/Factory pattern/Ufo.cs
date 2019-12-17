using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_pattern
{
    public class Ufo:EnemyShip
    {

        public Ufo(string name, byte hitpoints, int attackRange) : base(name, hitpoints, attackRange)
        {
        }
    }
}
