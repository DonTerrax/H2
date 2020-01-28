using System;
using System.Collections.Generic;
using System.Text;

namespace OldMaid
{
    class AIPlayer:Player
    {
        Random rnd;

        public AIPlayer(int playerID) : base(playerID)
        {

        }

        public override bool PlayTurn(Player playerToDrawFrom) //AI takes a random card
        {
            int cardIndex = rnd.Next(0, playerToDrawFrom.handAmount);
            Console.WriteLine("{0} takes a card from {1}",this,playerToDrawFrom);

            return TakeCardFromPlayer(playerToDrawFrom,cardIndex);
        }
        public override string ToString()
        {
            base.ToString();
            return "AI"+ base.ToString();
        }

       
    }
}
