class FuelGauge
{
    public string CarName { get; set; }

    public double ReadingFuelGauge { get; set; }
}

class CarFuelGauge
{
    public static List<FuelGauge> fuelGauges = new List<FuelGauge>();

    public static void AddFuelGauge(string carName, double readingFuelGauge)
    {
        fuelGauges.Add(new FuelGauge
        {
            CarName = carName,
            ReadingFuelGauge = readingFuelGauge
        });

        Console.WriteLine($"Fuel gauge to car {carName} filled and is {readingFuelGauge:0.0} liters");
    }

    public static void ChangeFuelGauge(string carName, double added)
    {
        int i = 0;
        double reading = 0;
        double current = 0;

        foreach(object fuelGauge in fuelGauges)
        {
            string propCarName = Convert.ToString(fuelGauge.GetType().GetProperty("CarName").GetValue(fuelGauge));
            double propReadingFuelGauge = Convert.ToDouble(fuelGauge.GetType().GetProperty("ReadingFuelGauge").GetValue(fuelGauge));
            
            reading = propReadingFuelGauge;
            current = propReadingFuelGauge + added;

            if(propCarName == carName)
            {
                fuelGauges[i] = new FuelGauge()
                {
                    CarName = propCarName,
                    ReadingFuelGauge = current
                };

                CarList.SearchCar(carName, current);
                if(added < 0)
                {
                    Console.WriteLine($"Car with name {propCarName} decreased by {added:0.0} liters!");
                }
                else if(added > 0)
                {
                    Console.WriteLine($"Car with name {propCarName} increased by {added:0.0} liters!");
                }     

                Console.WriteLine($"Car with name {propCarName} fuel now has {current:0.0} liters!");
                
                break;
            }

            i++;
        }   
    }

    public static void ReportFuelGaugeReadings()
    {
        foreach(object fuelGauge in fuelGauges)
        {
            string propCarName = fuelGauge.GetType().GetProperty("CarName").GetValue(fuelGauge).ToString();
            string propReadingFuelGauge = fuelGauge.GetType().GetProperty("ReadingFuelGauge").GetValue(fuelGauge).ToString();
            
            Console.WriteLine($"Fuel gauge of a car {propCarName} has reading {propReadingFuelGauge:0.0} liters");
        }
    }
}