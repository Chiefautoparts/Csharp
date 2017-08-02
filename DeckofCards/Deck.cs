using System.Collections.Generic;

namespace DeckofCards
{
    public class Deck
    {
        List<Card> cards;
        public Deck();
        {
            reset();
            shuffle();
        }

        public Deck reset()
        {
            cards = new List<Card>();
            string[] suits = {"hearts", "diamonds", "spades", "clubs"};
            string[] strVals = {"Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king"};
            foreach(string Suit in suits)
            {
                for (int i = 0; i<strVals.Length; i++)
                {
                    Card Foo = new Card(strVals[i], Suit, i+1);
                    cards.Add(Foo);
                
                }
            }
            return this;
        }
    }
    public Deck shuffle()
    {
        cards = new List<Card>();

    }
}