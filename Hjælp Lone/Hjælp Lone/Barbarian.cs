using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Lone
{
    class Barbarian:IMelee,ICharacter
    {
        public string Bash()
        {
            return "I'm bashing someone";
        }

        public string Cleave()
        {
            return "I'm cleaving someone";
        }

        public string Slash()
        {
            return "I'm S´slashing someone";
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
    }
}
