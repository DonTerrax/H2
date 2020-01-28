using System;

namespace OldMaid
{
    class Program
    {
        static void Main(string[] args)
        {
            CardManager cardManager = new CardManager();
            PlayerManager playerManager = new PlayerManager(0,GetIntFromPlayer("How many AI players?"));
            cardManager.ShuffleDeck(); // shuffle the deck
            cardManager.DealCards(playerManager);// Deals card out
            playerManager.StartGame(); // start game
            Random rnd = new Random(); 
            bool isRunning = true;
            while (isRunning)
            {
                if (!playerManager.NextTurn()) // checks if input was correct
                {
                    Console.WriteLine("Wrong number was entered");
                }

                isRunning = playerManager.Update();
            }

            Player loser = playerManager.LoosingPlayer(); // displays the loosing player
            Console.WriteLine("{0} lost", loser);
        }

        public static sbyte GetIntFromPlayer(string s,params object[] p)
        {
            sbyte val;
            do
            {
                Console.WriteLine(s,p);
            } while (!sbyte.TryParse(Console.ReadLine(),out val));

            return val;
        }
    }
    
}
