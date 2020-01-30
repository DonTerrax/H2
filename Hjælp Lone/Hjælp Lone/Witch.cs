using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Lone
{
    class Witch:ITeleport,IShield,ICharacter
    {
        public string Teleport(int x, int y)
        {
            return "Im teleporting";
        }

        public string RaiseShield()
        {
            return "I'm raising my shield";
        }

        public string ShieldGlare()
        {
            return "I'm throwing shield glare";
        }

        public string Heal()
        {
            return "I'm healing";
        }

        public string Die()
        {
            return "I'm dying";
        }

        public string Fight()
        {
            return "I'm fighting";
        }
    }
}
