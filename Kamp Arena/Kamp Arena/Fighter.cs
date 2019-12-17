using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_Arena
{
    class Fighter:IFighter
    {
        public Fighter(string name)
        {
            Name = name;
        }

        Random random = new Random();
        private int attackDmg;
        private bool hasEcasped;
        public string Name { get; }

        public int DefenseLeft { get; set; } = 30;

        public void Defend(int attack)
        {
            DefenseLeft -= attack;
        }

        public bool HasEscaped()
        {
            if (random.Next(0, 100) <= 15)
            {
                hasEcasped = true;
            }
            else
            {
                hasEcasped = false;
            }
            
            return hasEcasped = false;
        }


        public int Attack()
        {
            return attackDmg = random.Next(1, 6);
        }
    }
}
