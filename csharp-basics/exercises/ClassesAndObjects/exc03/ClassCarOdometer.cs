class Odometer
{
    public string CarName { get; set; }

    public int ReadingOdometer { get; set; }

    public int InitialReadingOdometer { get; set; }
}

class CarOdometer
{
    public static List<Odometer> odometers = new List<Odometer>();

    public static void AddOdometer(string carName, int readingOdometer)
    {
        odometers.Add(new Odometer
        {
            CarName = carName,
            ReadingOdometer = readingOdometer,
            InitialReadingOdometer = readingOdometer
        });

        Console.WriteLine($"Odometers to car {carName} added with mileage {readingOdometer}");
    }

    public static void ChangeOdometer(string carName, int added)
    {
        int i = 0;
        int readingOdometer = 0;

        foreach(object odometer in odometers)
        {
            string propCarName = Convert.ToString(odometer.GetType().GetProperty("CarName").GetValue(odometer));
            int propReadingOdometer = Convert.ToInt32(odometer.GetType().GetProperty("ReadingOdometer").GetValue(odometer));
            int _InitialReadingOdometer = Convert.ToInt32(odometer.GetType().GetProperty("InitialReadingOdometer").GetValue(odometer));
            
            readingOdometer = propReadingOdometer % 999999 > 0 ? (propReadingOdometer - 1) % 999999 : propReadingOdometer;
            
            if(readingOdometer % 10 == 0)
            {
                CarFuelGauge.ChangeFuelGauge(propCarName, -1); //decreasing fuel by 1 liter
            }

            if(propCarName == carName)
            {
                odometers[i] = new Odometer()
                {
                    CarName = propCarName,
                    ReadingOdometer = propReadingOdometer + added
                };
                
                break;
            }

            i++;
        }

        Console.WriteLine($"Odometers of a car {carName} changed with mileage {readingOdometer}");
    }

    public static void ReportOdometerReadings()
    {
        foreach(object odometer in odometers)
        {
            string propCarName = odometer.GetType().GetProperty("CarName").GetValue(odometer).ToString();
            string propReadingOdometer = odometer.GetType().GetProperty("ReadingOdometer").GetValue(odometer).ToString();
            
            Console.WriteLine($"Odometers of a car {propCarName} has reading {propReadingOdometer} km.");
        }
    }
}