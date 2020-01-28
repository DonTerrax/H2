using System;
using System.Collections.Generic;

namespace OldMaid
{
    class PlayerManager
    {
        private List<Player> players;
        private List<Player> finishedPlayers;
        private int playerTurn;

        public PlayerManager(sbyte numPlayers,sbyte numAI) // Creates objects of players and AI
        {
            playerTurn = 0;
            players = new List<Player>();
            finishedPlayers = new List<Player>();
            int playerID = 1;
            for (sbyte i = 0; i < numPlayers; i++)
            {
                players.Add(new HumanPlayer(playerID++));
            }
            for (sbyte i = 0; i < numAI; i++)
            {
                players.Add(new AIPlayer(playerID++));
            }
        }

        public void DealNextCard(Card card)
        {
            players[playerTurn].GiveCard(card);
            playerTurn++;
            WrapPlayerTurn();
        }

        void WrapPlayerTurn() //When all players have had their turn it returns to the first player
        {
            if (playerTurn >= players.Count)
            {
                playerTurn = 0;
            }
        }

        public void StartGame() //Put down pairs at the start of the game
        {
            foreach (Player player in players)
            {
                player.PutPairDown();
            }
        }

        public Player LoosingPlayer() // Tells who lost the game
        {
            if (players.Count == 1)
            {
                return players[0];
            }

            return null;
        }

        public bool Update() // Adds players to the finish list and writes it to the console
        {
            //check if players have cards left
            List<Player> finished = new List<Player>();
            foreach (Player player in players)
            {
                if (player.handAmount <= 0)
                { 
                    finished.Add(player);
                }
            }
            //
            foreach (Player player in finished)
            {
                Console.WriteLine("({0}) finished", player);
                players.Remove(player);
                finishedPlayers.Remove(player);
            }
            WrapPlayerTurn();

            return players.Count > 1;
        }

        public bool NextTurn() // Goes to the next player after turn ended and goes to the
                               // first player if the last player have had their turn
        {
            
            int nextPlayer = playerTurn + 1;  
            if (nextPlayer >= players.Count) 
            {
                nextPlayer = 0;
            }
            

            bool turnSucceeded = players[playerTurn].PlayTurn(players[nextPlayer]);
            if (!turnSucceeded)
            {
                return false;
            }

            playerTurn++;
            WrapPlayerTurn();
            return true;

        }
    }
}
