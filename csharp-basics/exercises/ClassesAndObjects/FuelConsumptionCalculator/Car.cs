namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _currentMileage; // Starting odometer reading
        private double _liters; // Liters of gas used between the readings

        public Car(double startOdo)
        {
            _currentMileage = startOdo;
        }

        public double CalculateConsumption()
        {
            return _currentMileage / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return (double) 100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15)
            {
                return true;
            }

            return false;
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5)
            {
                return true;
            }

            return false;
        }

        public void FillUp(int mileage, double liters)
        {
            _liters += liters;
            _currentMileage += mileage;
        }
    }
}
