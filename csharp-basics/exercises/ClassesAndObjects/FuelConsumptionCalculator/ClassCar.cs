using System;
using System.Reflection;
using System.Collections.Generic;

class Car
{
    public string Name { get; set; }

    public double StartKilometers { get; set; }

    public double EndKilometers { get; set; }

    public double Liters { get; set; }
}

class CarList
{
    public List<object> cars = new List<object>();

    public void AddCar(string name, double startKilometers, double endKilometers, double liters)
    {
        cars.Add( new { Name = name, StartKilometers = startKilometers, 
        EndKilometers = endKilometers, Liters = liters });
    }

    public void ChangeProductInfo()
    { 
        int i = 0;
        int detected = -1;
        
        Console.WriteLine("Please enter a car name to search: ");

        string searchName = Console.ReadLine()!;

        foreach(object o in cars)
        {
            if(o.GetType().GetProperty("Name").GetValue(o).ToString() == searchName)
            {
                detected = i;
            }

            i++;
        }

        if (detected != -1)
        {
            Console.Clear();

            var car = cars[detected];

            Console.WriteLine(car);

        }

        else
        {
            Console.Clear();
            Console.WriteLine($"car with name {searchName} is not found!");
        }
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

    public CarList(string name, double startKilometers, double endKilometers, double liters)
    {
        AddCar(name, startKilometers, endKilometers, liters);
    }
}