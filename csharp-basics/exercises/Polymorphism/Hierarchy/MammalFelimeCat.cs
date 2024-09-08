using System;

namespace Hierarchy
{
    public class Cat : Mammal
    {        
        public string _breed;

        public Cat(string animalName, string animalType, double animalWeight, 
        int foodEaten, string breed, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _breed = breed;
            _livingRegion = livingRegion;
        }
    }
}