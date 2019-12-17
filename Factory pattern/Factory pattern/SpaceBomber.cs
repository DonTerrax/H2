using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_pattern
{
    public class SpaceBomber:EnemyShip
    {
        private int bombSize;
        public int BombSize { get=> bombSize; set=> bombSize = value; }
        public SpaceBomber(string name, byte hitpoints, int attackRange,int bombSize) : base(name, hitpoints, attackRange)
        {
            BombSize = bombSize;
        }
    }
}
