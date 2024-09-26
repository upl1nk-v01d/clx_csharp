using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            var cars = new List<ICar>();

            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Tesla());
            cars.Add(new Mosquitch());
            cars.Add(new Sprinter());

            for(int i = 0; i < 10; i++)
            {
                if(i == 0)
                {
                    cars.ForEach(car => car.StartEngine());
                }

                else if(i == 2)
                {
                    cars.ForEach(car => 
                    {
                        if(car is IBoostable boostableCar)
                        {
                            boostableCar.UseNitrousOxideEngine();
                        }
                        else
                        {
                            car.SpeedUp();
                        }
                    });
                }
                else
                {
                    cars.ForEach(car => car.SpeedUp());
                }
            }

            var maxSpeed = cars.Max(car => int.Parse(car.ShowCurrentSpeed()));
            var fastestCar = cars.First(car => int.Parse(car.ShowCurrentSpeed()) == maxSpeed);
            var fastestCarName = fastestCar.GetType().Name;

            Console.WriteLine($"Fastest car is {fastestCarName} with speed {maxSpeed}");
        }
    }
}