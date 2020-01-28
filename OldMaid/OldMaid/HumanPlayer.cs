namespace OldMaid
{
    class HumanPlayer:Player
    {
        public HumanPlayer(int playerID) : base(playerID)
        {

        } 
        public override bool PlayTurn(Player playerToDrawFrom) //choose what card you want to take based on the cardindex. the total cardindex will be -1 next turn
        {
            int opponentCards = playerToDrawFrom.handAmount;
            int cardIndex = Program.GetIntFromPlayer("Your turn ({0}) take a card from {1} Press [1-{2}])): ",this,playerToDrawFrom,opponentCards);
            cardIndex--;
            return TakeCardFromPlayer(playerToDrawFrom, cardIndex);
        }

        public override string ToString()
        {
            return "Human" + base.ToString();
        }
    }
}
