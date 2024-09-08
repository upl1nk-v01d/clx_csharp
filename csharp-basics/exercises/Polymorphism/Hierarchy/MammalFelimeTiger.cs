using System;

namespace Hierarchy
{
    public class Tiger : Felime
    {        
        public Tiger(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _livingRegion = livingRegion;
        }
    }
}