namespace Human
{
    public class Monster
    {
        public string name;
        public int health {get; set;}
        public int strength {get; set;}
        public int dexterity {get; set;}
        public Monster(string title, int hp, int str, int dex)
        {
            name = title;
            strength = 5
            dexterity = 5;
            health = 150;
        }
        public void attack(object target)
        {
            Human enemy = target as Human;
            if (enemy != null)
            {
                enemy.health -= strength * 3;
            }
        }
    }
}