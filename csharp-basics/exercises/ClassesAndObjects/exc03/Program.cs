using System;

class Program
{
    static private void Main(string[] args)
    {
        var carList = new CarList("Ferrari",0,200,10);

        carList.AddCar("Porche", 0, 230, 6.4); 
        carList.AddCar("Bentley", 0, 130, 8.1); 
        carList.AddCar("Audi", 0, 90, 4.8); 

        //carList.Report();

        bool quit = false;
        
        while(!quit)
        {
            string prompt = "";
            
            Console.Write("Please enter a car name: ");
            prompt = Console.ReadLine();

            if(prompt != "")
            {

                object car = CarList.SearchCar(prompt);

                if(car != null)
                {
                    string carName = Convert.ToString(car.GetType().GetProperty("Name").GetValue(car));
                    int startKilometers = Convert.ToInt32(car.GetType().GetProperty("StartKilometers").GetValue(car));
                    int endKilometers = Convert.ToInt32(car.GetType().GetProperty("EndKilometers").GetValue(car));
                    double liters = Convert.ToDouble(car.GetType().GetProperty("Liters").GetValue(car));
                
                    Console.Write("Press any key to watch odometer changing...");
                    Console.ReadKey(true);

                    for(int i = 0; i < 5; i++)
                    {
                        CarOdometer.ChangeOdometer(carName, 1);
                    }
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
