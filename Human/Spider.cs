using System;

namespace Human
{
    public class Spider : Human
    {
        public Spider(string n) : base(n)
        {
            health = 100;
            strength = 15;
            intelligence = 10;
            dexterity = 25;
            
        }
        public void poison(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
                enemy.is_poisoned = true;
                enemy.health -= 5;
            }
        }
        public void strike(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
                Attack(enemy);
            }
        }
    }
}