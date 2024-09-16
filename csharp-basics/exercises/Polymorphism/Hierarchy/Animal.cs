namespace Hierarchy
{
    public abstract class Animal
    {
        public string _animalName;

        public string _animalType;

        public double _animalWeight;

        public int _foodEaten;
        
        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public virtual void MakeSound()
        {
        }
        
        public string Eat(Food food)
        {
            if(food.GetType().Name == "Meat")
            {
                return $"{this._animalType} is eating {food.GetType().Name}!";
            }

            return $"{this._animalType} is not eating {food.GetType().Name}!";
        }
    }
}