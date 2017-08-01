using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
         Human person1 = new Human("tom", 9, 2, 4, 250);
         System.Console.WriteLine(person1.name);
         person1.attack("bill");
        }
    }
    public class Human
    {
        public Human(string name, int strength, int intelligence, int dexterity, int health) 
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
               
        }
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; } 
        // public People(string newName)
        // {
        //     name = newName;
        // }
        public int damage()
        {
            return strength * 5;
        }
        // public void attack(object target)
        // {
        //     enemy = Human;
        //     enemy = target;
        //     if(enemy != null); 
        //     {
        //        enemy.hp -= damage;
        //     }
        // }
    }

}
