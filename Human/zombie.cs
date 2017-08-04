using System;

namespace Human
{
    public class Zombie : Human
    {
        public Zombie(string n) : base(n)
        {
            strength = 10;
            intelligence = 1;
            dexterity = 5;
            health = 175;
        }
        public void bite(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
                enemy.health -= strength * 2;
            }
        }
        public void brains()
        {
            health += 10;
            Console.WriteLine("Braaaaaaaaaaaaaaaaaains");
        }
    }
}