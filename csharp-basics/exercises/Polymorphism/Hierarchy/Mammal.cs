namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string _livingRegion;
        
        protected Food _foodType;
        
        public Mammal(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
            _foodType = foodType;
        }

        public virtual string GetLivingRegion()
        {
            return _livingRegion;
        }
    }
}