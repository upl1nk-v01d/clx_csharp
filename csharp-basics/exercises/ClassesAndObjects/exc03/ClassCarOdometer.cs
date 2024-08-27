class Odometer
{
    public string CarName { get; set; }

    public int Reading { get; set; }
}

class CarOdometer
{
    public static List<Odometer> odometers = new List<Odometer>();

    public static void AddOdometer(string carName, int reading)
    {
        odometers.Add(new Odometer
        {
            CarName = carName,
            Reading = reading
        });

        Console.WriteLine($"Odometers to car {carName} added with mileage {reading}");
    }

    public static void ChangeOdometer(string carName, int added)
    {
        int i = 0;
        int reading = 0;

        foreach(object odometer in odometers)
        {
            string propCarName = Convert.ToString(odometer.GetType().GetProperty("CarName").GetValue(odometer));
            int propReading = Convert.ToInt32(odometer.GetType().GetProperty("Reading").GetValue(odometer));
            
            reading = propReading;

            if(propCarName == carName)
            {
                odometers[i] = new Odometer
                {
                    CarName = propCarName,
                    Reading = propReading + added
                };
            }

            i++;
        }

        Console.WriteLine($"Odometers of a car {carName} changed with mileage {reading}");
    }

    public static void ReportOdometerReadings()
    {
        foreach(object odometer in odometers)
        {
            string propCarName = odometer.GetType().GetProperty("CarName").GetValue(odometer).ToString();
            string propReading = odometer.GetType().GetProperty("Reading").GetValue(odometer).ToString();
            
            Console.WriteLine($"Odometers of a car {propCarName} has reading {propReading} km.");
        }
    }
}