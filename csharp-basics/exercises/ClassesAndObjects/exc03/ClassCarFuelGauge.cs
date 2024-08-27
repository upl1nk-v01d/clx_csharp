class CarFuelGauge
{
    public static double CalculateConsumption(double startKilometers, double endKilometers, double liters)
    {
        return (endKilometers - startKilometers) / liters;
    }

    public static double CalculateConsumption100KM(double mileage, double liters)
    {
        return liters / mileage * 100;
    }
}