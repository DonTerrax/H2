using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Lone
{
    class Knight:ICharacter,IMelee,IShield
    {
        public string Bash()
        {
            return "I'm bashing someone";
        }

        public string Cleave()
        {
            return "I'm cleaving someone";
        }

        public string Die()
        {
            return "I'm dying";
        }

        public string Fight()
        {
            return "I'm fighting";
        }

        public string Heal()
        {
            return "I'm healing";
        }

        public string RaiseShield()
        {
            return "I'm raising my shield";
        }

        public string ShieldGlare()
        {
            return "I'm throwing shield glare";
        }

        public string Slash()
        {
            return "I'm slashing someone";
        }
    }
}
