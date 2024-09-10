using System;

namespace Hierarchy
{
    public abstract class Felime : Mammal
    {    
        public Felime(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _foodType = foodType;
        }
    }
}