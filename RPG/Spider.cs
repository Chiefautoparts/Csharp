using System;

namespace Human
{
    public class Spider : Monster
    {
        public Spider(string n) : base(n)
        {
            health = 200;
            strength = 25;
        }
        public void bite(object target)
        {
            Human enemy = target as Human;
            if (enemy != null)
            {
                attack(enemy);
                enemy.is_poisoned = true;
            }
        }
    }
}