using System;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card jon = new Card("jon", "black", 1);
            System.Console.WriteLine(jon.val);
        }
    }
}
