using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Kamp_Arena
{
    interface IFighter
    {
        string Name { get; }
        //Denne property skal angive hvor mange forsvarspoint den pågældende fighter har tilbage
        int DefenseLeft { get; }

        //Denne metode kaldes når fighteren skal forsvare sig
        void Defend(int attack);

        //return true hvis fighteren stikker af
        bool HasEscaped();

        //Denne metode kaldes når fighteren skal angribe
        //og returnere en int værdi med hvor meget han/hun angriber

        int Attack();

    }
}
