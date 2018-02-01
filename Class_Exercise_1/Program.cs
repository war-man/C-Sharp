using System;

namespace Class_Exercise_1
{
    class Car 
    {
        public string Brand { get; set; } = "Lambo";
        public string Color { get; set; } = "Red";
        public int Year { get; set; } = 2014;
        public int Mileage { get; set; } = 20000;
        
        public static int Count;

        public Car()
        {
            Car.Count++;
        }

        public Car(string brand, string color, int year, int mileage)
        {
            this.Brand = brand;
            this.Color = color;
            this.Year = year;
            this.Mileage = mileage;
            Car.Count++;
        }

        public static int CountCar()
        {
            return Car.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            var car2 = new Car("Mercedes", "Red", 2014, 20000);
            var car3 = new Car("Ferrari", "Red", 2016, 30000);
            var car4 = new Car("BMW", "White", 2015, 50000);
            var car5 = new Car();
            var car6 = new Car();
            var car7 = new Car("Ford", "Grey", 2016, 70000);

            var count = Car.CountCar();

            Console.WriteLine($"Number of cars created: {count}");
            Console.WriteLine($"Car1 features: {car1.Brand} - {car1.Color} - {car1.Year} - {car1.Mileage}");

            car7.Brand = "Porsche";

            Console.WriteLine($"Car 7 changed brand to: {car7.Brand}");
        }
    }
}
