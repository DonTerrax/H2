using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Lone
{
    interface ICharacter
    {
        string Heal();
        string Die();
        string Fight();
    }
}
