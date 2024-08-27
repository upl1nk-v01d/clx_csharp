class CarFuel
{
    public static double CalculateConsumption(double startKilometers, double endKilometers, double liters)
    {
        return (endKilometers - startKilometers) / liters;
    }

    public double Consumption100KM(double startKilometers, double endKilometers, double liters)
    {
        return liters / (endKilometers - startKilometers) * 100;
    }

    public bool IsGasHog(double startKilometers, double endKilometers, double liters)
    {
        return Consumption100KM(startKilometers, endKilometers, liters) > 15;
    }

   public bool IsEconomyCar(double startKilometers, double endKilometers, double liters)
    {
        return Consumption100KM(startKilometers, endKilometers, liters) <= 5;
    }
}