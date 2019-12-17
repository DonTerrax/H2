using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_pattern
{
    public class SpaceFighter:EnemyShip
    {
        private byte warpSpeed;
        public byte WarpSpeed { get=> warpSpeed; set=> warpSpeed = value; }
        public SpaceFighter(string name, byte hitpoints, int attackRange, byte warpSpeed) : base(name, hitpoints, attackRange)
        {
            WarpSpeed = warpSpeed;
        }
    }
}
