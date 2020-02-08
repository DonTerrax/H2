using System;
using System.Collections.Generic;

namespace OldMaid
{
    class CardManager
    {
        Random rnd = new Random();

        private List<Card> deck;

        
        public CardManager() //Create decks for players
        {
            
            rnd = new Random();
            deck = new List<Card>();
            deck.Add(new OldMaid());
            for (int i = 0; i < 16; i++)
            {
                deck.Add(new NumberCard(i));
                deck.Add(new NumberCard(i));
            }
        }
       

        public void ShuffleDeck() // Shuffle cards and put them in the sufflecards list and removes them from the deck list
        {
            List<Card> shufflecards = new List<Card>();
            while (deck.Count > 0)
            {
                int card = rnd.Next(0, deck.Count);
                shufflecards.Add(deck[card]);
                deck.RemoveAt(card);
            }

            deck = shufflecards;
        }

        public void DealCards(PlayerManager players) // Deal cards to all players
        {
            while (deck.Count > 0)
            {
                Card card = deck[0];
                players.DealNextCard(card);
                deck.RemoveAt(0);
            }
        }

    }
}
