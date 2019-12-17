using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_Arena
{
    class WizardAdapter:IFighter
    {
        Random random = new Random();
        private bool hasEcasped;
        private Wizard wizard;
        

        public WizardAdapter(Wizard wizard)
        {
            this.wizard = wizard;
        }
       

        public string Name { get; }
        public int DefenseLeft { get; set; } = 20;
        public void Defend(int attack)
        {
            wizard.Shield(attack);
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
            return wizard.CastFireballSpell();
            
        }
    }
}
