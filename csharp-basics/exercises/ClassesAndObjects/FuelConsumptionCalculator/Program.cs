using System;

class Program
{
    static private void Main(string[] args)
    {
        var carList = new CarList("Ferrari",0,200,10);

        carList.AddCar("Porche", 0, 230, 6.4); 
        carList.AddCar("Bentley", 0, 130, 8.1); 
        carList.AddCar("Audi", 0, 90, 4.8); 

        carList.Report();

        bool quit = false;
        
        while(!quit)
        {
            Console.Write("Please enter a car name: ");
            string prompt = Console.ReadLine();

            if(prompt != "")
            {

                object car = carList.SearchCar(prompt);

                if(car != null)
                {
                    string carName = Convert.ToString(car.GetType().GetProperty("Name").GetValue(car));
                    int startKilometers = Convert.ToInt32(car.GetType().GetProperty("StartKilometers").GetValue(car));
                    int endKilometers = Convert.ToInt32(car.GetType().GetProperty("EndKilometers").GetValue(car));
                    double liters = Convert.ToDouble(car.GetType().GetProperty("Liters").GetValue(car));
                    
                    int mileage = endKilometers - startKilometers;

                    bool IsGasHog = Convert.ToBoolean(Car.IsGasHog(mileage,liters));
                    bool IsEconomyCar = Convert.ToBoolean(Car.IsEconomyCar(mileage,liters));
                    
                    double consumption = CarTest.CalculateConsumption100KM(mileage, liters);
                    string isGasHog = IsGasHog == true ? "gas hog" : "not a gas hog";
                    string isEconomyCar = IsEconomyCar == true ? "economy car" : "not an economy car";

                    Console.WriteLine($"Car's {carName} fuel consumption is {consumption:0.00} liters on 100 km.");
                    Console.WriteLine($"Car's {carName} is {isGasHog}.");
                    Console.WriteLine($"Car's {carName} is {isEconomyCar}.");
                }

                Console.WriteLine();
                Console.WriteLine("Please 'Q' key to quit!");
                Console.WriteLine("Please press any key to continue!");
                
                if(Console.ReadKey(true).Key.ToString() == "Q")
                {
                    quit = true;
                } 
                else
                {
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter some car name!");
            }

            if(quit)
            {
                Console.Clear();
                Console.WriteLine("Goodbye! :)");
                Console.Clear();
            }
        }
    }
}
