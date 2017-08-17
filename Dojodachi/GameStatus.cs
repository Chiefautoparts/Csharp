namespace Dojodachi
{
    public class GameStatus
    {
        public int Fullness {get; set;}
        public int Happiness {get; set;}
        public int Meals {get; set;}
        public int Energy {get; set;}
        public int Level {get; set;}
        public GameStatus()
        {
            Fullness = 20;
            Happiness = 20;
            Meals = 3;
            Energy = 50;
            Level = 1;
        }
    }
}