using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car
    {
        protected int year;
        protected string model;
        protected string brand;
        protected double fuel_per_100_kilometers = 6.5;
        protected double fuelConsume;
        public Car(string b, string m, int y)
        {
            brand = b;
            model = m;
            year = y;
            fuelConsume = fuel_per_100_kilometers;
        }
        public double CalculateFuelConsume(double distance)
        {
            return fuelConsume = distance * fuel_per_100_kilometers / 100;
        }
        public void Display()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nYear: {2}\nFuel consume: {3}\n", brand, model, year, fuelConsume);
        }
    }

    class ecoCar : Car
    {
        private double fuelPrice;
        private double distance;
        public ecoCar(string b, string m, int y) : base(b, m, y) { }
        public void setFuelConsume(double f) 
        {
            fuel_per_100_kilometers = f;
        }
        public void set_Price_Distance(double p, double d)
        {
            fuelPrice = p;
            distance = d;
        }
        public void Display()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nYear: {2}\nFuel consume per 100 kilometers: {3}" +
                "\nFuel Price: {4}\nDistance: {5}\n", brand, model, year, fuelConsume,fuelPrice,distance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car("Mercedes","C",2015);
            newCar.Display();
            ecoCar myCar = new ecoCar("Toyota", "Auris", 2010);
            myCar.Display();
            myCar.setFuelConsume(10);
            myCar.CalculateFuelConsume(100);
            myCar.Display();

            Console.ReadLine();
        }
    }
}
