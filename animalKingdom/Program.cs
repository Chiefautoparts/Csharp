using System;

namespace animalKingdom
{
    public class Program
    {
        static void Main(string[] args)
        {
            animal Dog = new animal(4);
            Console.WriteLine("This Animal has " + Dog.numlegs + " legs");
            // Dog.Dog(4, "steve", 20);
            // Console.WriteLine("the number of legs is " + Dog.Numlegs);

            // Console.WriteLine(Dog.Numlegs);
            // Dog bob = new Dog();
            // Console.WriteLine();
            // bob.speak("woof");
            // Console.WriteLine();
        }
    }
}
