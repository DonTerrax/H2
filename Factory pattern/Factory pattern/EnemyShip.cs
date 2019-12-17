using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_pattern
{
    public abstract class EnemyShip
    {
        private string name;
        private byte hitpoints;
        private int attackRange;

        public string Name { get => name; set => name = value; }
        public byte Hitpoints { get=> hitpoints; set=> hitpoints = value; }

        public int AttackRange { get=> attackRange; set=> attackRange = value; }

        protected EnemyShip(string name, byte hitpoints,int attackRange)
        {
            Name = name;
            Hitpoints = hitpoints;
            AttackRange = attackRange;
        }

        public override string ToString()
        {
            return Name;
        }

        
    }
}
