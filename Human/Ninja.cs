using System;

namespace Human
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n)
        {
            dexterity = 175;
        }
        public void steal(object target)
        {
            Human enemy = target as Human;
            if(enemy != null) 
            {
                Attack(enemy);
                health += 10;
            }
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}