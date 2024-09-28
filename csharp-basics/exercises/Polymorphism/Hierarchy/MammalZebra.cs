namespace Hierarchy
{
    public abstract class Zebra : Mammal
    {        
        public Zebra(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _livingRegion = livingRegion;
            _foodType = foodType;
        }
    }
}