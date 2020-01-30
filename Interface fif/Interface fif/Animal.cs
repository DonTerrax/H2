using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_fif
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Consume();
       

        protected void Die()
        {
            Console.WriteLine("Animal is dead");
        }

        public void Kill()
        {
            Die();
        }
    }
}
