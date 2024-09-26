using System;
using System.Reflection;
using System.Collections.Generic;

class Car
{
    public string Name { get; set; }

    public int StartKilometers { get; set; }

    public int EndKilometers { get; set; }

    public double Liters { get; set; }

    public static bool IsGasHog(double mileage, double liters)
    {
        return CarTest.CalculateConsumption100KM(mileage, liters) > 15;
    }

    public static bool IsEconomyCar(double mileage, double liters)
    {
        return CarTest.CalculateConsumption100KM(mileage, liters) <= 5;
    }
}

class CarList
{
    public List<object> cars = new List<object>();

    public void AddCar(string name, int startKilometers, int endKilometers, double liters)
    {
        cars.Add( new Car { Name = name, StartKilometers = startKilometers, 
        EndKilometers = endKilometers, Liters = liters });
    }

    public object SearchCar(string searchName, double addLiters = 0.0)
    { 
        int i = 0;
        int detected = -1;

        foreach(var o in cars)
        {
            if(o.GetType().GetProperty("Name").GetValue(o).ToString().ToLower() == searchName.ToLower())
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
            Console.WriteLine($"car with name {searchName} is found!");

            if(addLiters != 0)
            {
                object car = new Car()
                {
                    Name = Convert.ToString(cars[detected].GetType().GetProperty("Name").GetValue(cars[detected])),
                    StartKilometers = Convert.ToInt32(cars[detected].GetType().GetProperty("StartKilometers").GetValue(cars[detected])),
                    EndKilometers = Convert.ToInt32(cars[detected].GetType().GetProperty("EndKilometers").GetValue(cars[detected])),
                    Liters = addLiters,
                };

                Console.WriteLine($"car with name {searchName} added liters {addLiters}!");
                
                cars[detected] = car;
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

    public void FillUp(string carName, int mileage, double liters)
    {
        object car = SearchCar(carName);

        double Liters = Convert.ToDouble(car.GetType().GetProperty("Liters").GetValue(car));
        double fillUpLiters = CarTest.CalculateConsumption100KM(mileage, liters);

        SearchCar(carName, fillUpLiters);

        Console.WriteLine(Liters);
    }

    public CarList(string carName, int startKilometers, int endKilometers, double liters)
    {
        AddCar(carName, startKilometers, endKilometers, liters);

        int mileage = endKilometers - startKilometers;
        FillUp(carName, mileage, liters);
    }
}