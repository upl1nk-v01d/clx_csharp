using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;

        private const double PurchasedEnergyDrinks = 0.14;

        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {            
            int energyDrinkers = Convert.ToInt32(CalculateEnergyDrinkers(NumberedSurveyed));
            int preferCitrus = Convert.ToInt32(CalculatePreferCitrus(energyDrinkers));

            Console.Clear();
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
            Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");
        }

        private static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return NumberedSurveyed * PurchasedEnergyDrinks;
        }

        private static double CalculatePreferCitrus(int energyDrinkers)
        {
            return energyDrinkers * PreferCitrusDrinks;
        }
    }
}
