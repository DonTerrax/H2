using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_pattern
{
    class EnemyFactory
    {
        Random r = new Random();
        public EnemyShip CreateEnemyShip()
        {
            //Herinde laver vi en random som sørger for at vi får et random fjendeskib
            int t = r.Next(5) + 1;
            switch (t)
            {
                case 1: return new SpaceFighter("SS Bayonet Fighter", 35, 250, 1); 
                case 2: return new SpaceFighter("Snif fighter", 8, 200, 3);
                case 3: return new SpaceFighter("Galaxy Fighter 8000", 30, 60, 2);
                case 4: return new Ufo("Galaxy Fighter 8000", 10, 400);
                case 5: return new SpaceBomber("HWSS Gladiator", 60, 500, 254);
                default:
                    return null;

            }
        }

    }
}
