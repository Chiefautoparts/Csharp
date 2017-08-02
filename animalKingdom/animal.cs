namespace animalKingdom
{
    public class animal
    {
        public int numlegs;
        public double speed = 0.0;
        public int weight;
        // public void Dog(int legs, string name, int weight){
        //     numlegs = legs;
        //     this.name = name;
        //     this.weight = weight;
        // }
        public animal(int legs)
        {
            numlegs = legs;
        }
        public void Speed(double mph)
        {
            this.speed = mph;
        }
       // public string Speak()
    }
}