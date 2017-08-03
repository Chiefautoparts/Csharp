using System;
using System.Collections.Generic;
namespace DeckofCards
{
    public class Player
    {
        public List<Card> hand = new List<Card>();
        string name;
        public Player (string nameString)
        {
            name = nameString;
        }
        public Card drawCard(Deck deck)
        {
            Card drawnCard = deck.dealCard();
            hand.Add(drawnCard);
            return drawnCard;
        }
        public Card removeCard(int idx)
        {
            if (idx <= hand.Count - 1){
                Card removedCard = hand[idx];
                hand.RemoveAt(idx);
                return removedCard;
            } 
            else
            {
                return null;
            }
        }
    }
}