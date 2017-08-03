using System;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deckUno = new Deck();
            Player doug = new Player("doug");
            Console.WriteLine(deckUno);
        }
    }
}
