using System;
using System.Reflection;
using System.Collections.Generic;

class Car
{
    public string Name { get; set; }

    public int StartKilometers { get; set; }

    public int EndKilometers { get; set; }

    public double Liters { get; set; }
}

class CarList
{
    public static List<Car> cars = new List<Car>();

    public void AddCar(string carName, int startKilometers, int endKilometers, double liters)
    {
        cars.Add( new Car { 
            Name = carName, 
            StartKilometers = startKilometers, 
            EndKilometers = endKilometers,
            Liters = liters 
        });

        CarOdometer.AddOdometer(carName, endKilometers);
    }

    public static object SearchCar(string searchName, double addLiters = 0.0)
    { 
        int i = 0;
        int detected = -1;

        string propName = "";

        foreach(var o in cars)
        {
            propName = o.GetType().GetProperty("Name").GetValue(o).ToString();
            
            if(propName.ToLower() == searchName.ToLower())
            {
                detected = i;
                Console.WriteLine(detected);
            }

            i++;
        }

        if (detected == -1)
        {
            Console.Clear();
            Console.WriteLine($"car with name {searchName} is not found!");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"car with name {propName} is found!");

            if(addLiters != 0)
            {
                cars[detected] = new Car()
                {
                    Name = Convert.ToString(cars[detected].GetType().GetProperty("Name").GetValue(cars[detected])),
                    StartKilometers = Convert.ToInt32(cars[detected].GetType().GetProperty("StartKilometers").GetValue(cars[detected])),
                    EndKilometers = Convert.ToInt32(cars[detected].GetType().GetProperty("EndKilometers").GetValue(cars[detected])),
                    Liters = addLiters,
                };

                Console.WriteLine($"car with name {propName} added liters {addLiters}!");
            } 
            else
            {
                object car = cars[detected];
            }
            
            return cars[detected];
        }

        return null;
    }

    public void Report()
    {
        int i = 0;

        Console.WriteLine();
        Console.WriteLine("Printing list of cars:\n");

        foreach (object o in cars)
        {
            foreach (PropertyInfo p in cars[i].GetType().GetProperties())
            {
                Console.Write(p.Name + ": ");
                Console.WriteLine(p.GetValue(cars[i])); 
            }
     
            Console.WriteLine();

            i++;
        }
    }

    public CarList(string carName, int startKilometers, int endKilometers, double liters)
    {
        this.AddCar(carName, startKilometers, endKilometers, liters);
    }
}