using System;

namespace Hierarchy
{
    public abstract class Felime : Mammal
    {        
        public Felime(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _livingRegion = livingRegion;
            _foodType = foodType;
        }

        public override string eat(Food food)
        {
            if(food.GetType().Name == "Meat")
            {
                return $"{this._animalType} is eating {food.GetType().Name}!";
            }

            return $"{this._animalType} is not eating {food.GetType().Name}!";
        }
    }
}