using System;

namespace classesPreactice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle(7);
            Console.WriteLine("My vehicle can hold" + myVehicle.numPassengers + " people");
            Vehicle car = new Vehicle(5);
            Vehicle bike = new Vehicle(1);
            Console.WriteLine(car.distance);
            Console.WriteLine(bike.distance);
            car.Move(70.8);
            Console.WriteLine(car.distance);
            Console.WriteLine(bike.distance);
        }
    }
    public class Vehicle
    {
        public int numPassengers;  
        public double distance = 0.0;
        public Vehicle(int val)
        {
            numPassengers = val;
        }
        public Vehicle(int val, double odo)
        {
            numPassengers = val;
            distance = odo;
        }
        public int Move(double miles)
        {
            distance += miles;
            return (int)distance;
        }
        public int Move(double miles, bool km)
        {
            if (km == true)
            {
                miles = miles * 0.62;
            }
            return Move(miles);
        }
    }
}
