namespace Human
{
public class Human
    {   
        public string name;
        public int health {get; set;} 
        public int strength {get; set;}
        public int intelligence {get; set;}
        public int dexterity {get; set;}

        public Human(string person)
        {
            name = person;
            health = 100;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
        }
        public Human(string person, int hp, int str, int intl, int dex)
        {
            name = person;
            health = hp;
            strength = str;
            intelligence = intl;
            dexterity = dex;
        }
        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy != null)
            {
             enemy.health -= strength * 5;
            }
        }
    }
}