using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Honda";
            myNewCar.Model = "Civic";
            myNewCar.Year = 1998;
            myNewCar.Color = "red";

            Console.WriteLine("{0} - {1} - [2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            Console.WriteLine("Car's value: {0:C}", myNewCar.determineMarketValue());

            Console.ReadLine();
        }

        private static double determineMarketValue(Car _car)
        {
        double carValue = 100.0;

        return carValue;

        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double determineMarketValue()
        {
            double carValue = 100.0;
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;

        }
    }
}