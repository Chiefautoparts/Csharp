using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public string[] suits = {"hearts", "diamonds", "spades", "clubs"};
        public string[] strVals = {"Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king"};

        public Deck()
        {
            for (int a = 0; a < suits.Length; a++)
            {
                for (int h = 0; h < strVals.Length; h++)
                {
                    Card newCard = new Card(strVals[h], suits[a], h+1);
                    
                    cards.Add(newCard);
                }
            }
            System.Console.WriteLine(cards);
        }
        public Card dealCard()
        {
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }
        
        public void resetDeck()
        {
            cards = new List<Card>();
            for (int n = 0; n < strVals.Length; n++)
            {
                for (int m = 0; m < suits.Length; m++)
                {
                    Card newCard = new Card(strVals[n], suits[m], n+1);
                    cards.Add(newCard);
                }
            }
        }
        public void shuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                Card temp = cards[i];
                int rando = rand.Next(0, cards.Count);
                cards[i] = cards[rando];
                cards[rando] = temp;
            }
            System.Console.Write("shuffle");
        }
    }
}