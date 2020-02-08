using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Lone
{
    class Wizard:ISpell,ICharacter
    {
        public string ThrowFrostNova()
        {
            return "I'm throwing my frost nova";
        }

        public string ThrowMagicMisile()
        {
            return "I'm throwing a magic misile";
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
