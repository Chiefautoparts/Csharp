namespace DeckofCards{
    public class Card
    {
        string  strVal;

        string suit;

        int val;

        public Card(string name, string suitType, int value)
        {
            strVal = name;
            suit = suitType;
            val = value;
        }
    }
}