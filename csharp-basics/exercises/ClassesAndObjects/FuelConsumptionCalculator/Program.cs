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
            double consumption = CarFuel.CalculateConsumption(0, 100, 13);

            Console.WriteLine(consumption);

            //carList.Report();

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

            if(quit)
            {
                Console.Clear();
                Console.WriteLine("Goodbye! :)");
                Console.Clear();
            }
        }
    }
}
