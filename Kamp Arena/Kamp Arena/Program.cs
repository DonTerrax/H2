using System;

namespace Kamp_Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter("ludvig");
            Fighter f2 = new Fighter("ole");
            IFighter wizard = new WizardAdapter(new Wizard("Merlin"));
            


            Console.WriteLine($"The winner is {Fight(f1, wizard).Name}");

        }
        public static IFighter Fight(IFighter f1, IFighter f2)
        {

            while (!f1.HasEscaped() && !f2.HasEscaped() && f1.DefenseLeft > 0 && f2.DefenseLeft > 0)
            {
                // Første fighter henter attack
                int attack = f1.Attack();
                // Anden fighter skal forsvare sig
                f2.Defend(attack);
                // Anden fighter henter attack
                attack = f2.Attack();
                // Første fighter skal forsvare sig
                f1.Defend(attack);
            }

            IFighter winner = null;


            // kampen er afsluttet
            if ((f1.DefenseLeft > 0) && (!f1.HasEscaped()))
                winner = f1;

            if ((f2.DefenseLeft > 0) && (!f2.HasEscaped()))
                winner = f2;

            // Hvis der returneres null, så har kampen været jævnbyrdig
            return winner;
        }
    }
}
