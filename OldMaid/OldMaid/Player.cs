using System.Collections.Generic;

namespace OldMaid
{
    
    abstract class Player //an abstract class is designed to be iherited
                          //by subclasses that either implement or override its methods
    {
        
        private List<Card> hand { get; }
        public List<NumberCard> tablePairs { get; }
        public int PlayerID { get; }
        public int handAmount
        {
            get { return hand.Count; }
        }

        public Player(int playerID) // constructor
        {
            PlayerID = playerID;
            hand = new List<Card>();
            tablePairs = new List<NumberCard>();
        }

        
        List<NumberCard> CheckForPair() //Here we check for pairs by running through the list with a for loop.
                                        //If there is a pair we add it to the pair list
        {
            List<NumberCard> pairs = new List<NumberCard>();
            for (int i = 0; i < hand.Count - 1; i++)
            {
                for (int j = i+1; j < hand.Count; j++)
                {
                    if (hand[i] is NumberCard && hand[j] is NumberCard)
                    {
                        NumberCard card1 = hand[i] as NumberCard;
                        NumberCard card2 = hand[j] as NumberCard;
                        if (((NumberCard)hand[i]).Number == ((NumberCard)hand[j]).Number)
                        {
                            pairs.Add(card1);
                            pairs.Add(card2);
                        }
                    }
                }
            }

            return pairs;
        }

        public void GiveCard(Card card) // adds a card to the hand list
        {
            hand.Add(card);
        }

        public Card DrawFrom(int index) // 
        {
            if (index < 0 || index >= hand.Count)
            {
                return null;
            }

            Card card = hand[index];
            hand.Remove(card);
            return card;
        }

        public abstract bool PlayTurn(Player playerToDrawFrom);

         
        public bool TakeCardFromPlayer(Player playerToDrawFrom,int cardIndex) //Here we take a card from another
                                                                              //players hand and add it to the player hand
        {
            
            Card card = playerToDrawFrom.DrawFrom(cardIndex);
            if (card == null)
            {
                return false;
            }
            hand.Add(card);
            PutPairDown();
            return true;
        }
       

        public void PutPairDown()  // here we check the pairs list for pairs.
                                   // If there is a pair its removed from the hand and added to the tablepairs list
        {
            List<NumberCard> pairs = CheckForPair();
            foreach (NumberCard card in pairs)
            {
                hand.Remove(card);
                tablePairs.Add(card);
                
            }
        }
        public override string ToString()
        {
            base.ToString();
            return "(" + PlayerID + ")(has " + handAmount + " card(s)";
        }


    }
}
