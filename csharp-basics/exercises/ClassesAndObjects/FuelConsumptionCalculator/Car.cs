namespace FuelConsumptionCalculator
{
    public class Car
    {
        public Car(double startOdo)
        {
            
        }

        public double CalculateConsumption()
        {
            return 0;
        }

        private double ConsumptionPer100Km()
        {
            return 0;
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
        }
    }
}
