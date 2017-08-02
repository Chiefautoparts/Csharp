using System.Collections.Generic;

namespace Human
{
    public class Wizard :Human
    {
        public class Wizard(string n):base(n)
        {
            health = 50;
            intelligence = 25;
        } 
    }
}