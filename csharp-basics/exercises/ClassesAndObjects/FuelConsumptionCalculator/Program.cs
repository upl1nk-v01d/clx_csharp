using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers, endKilometers, liters;

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter second reading: ");
            endKilometers = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter liters consumed: ");
            liters = Convert.ToDouble(Console.ReadLine());

            //Car car = new Car( ?, ?, ?);

          //  Console.WriteLine("Kilometers per liter are " + car.calculateConsumption());
        }
    }
}
