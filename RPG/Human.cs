namespace Human
{
public class Human
    {   
        public string name;
        public int health {get; set;} 
        public int strength {get; set;}
        public int intelligence {get; set;}
        public int dexterity {get; set;}
        public bool is_poisoned;

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            is_poisoned = false;
        }
        public Human(string person, int str, int intl, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intl;
            dexterity = dex;
            health = hp;
            is_poisoned = false;
        }
        public void Attack(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
             enemy.health -= strength * 5;
            }
        }
        
    }
}