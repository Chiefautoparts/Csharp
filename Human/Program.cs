using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
         Human person1 = new Human("Tim", 200, 8, 2, 4);
         Console.WriteLine(person1.name + " has " + person1.health + " Health points");
        }
    }

}
