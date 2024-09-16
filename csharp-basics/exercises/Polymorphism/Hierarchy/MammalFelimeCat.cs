using System;

namespace Hierarchy
{
    public class Cat : Mammal
    {        
        protected string _breed;

        public string _sound = "meow";

        public Cat(string animalName, string animalType, double animalWeight, 
        int foodEaten, string breed, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _breed = breed;
            _livingRegion = livingRegion;
        }

        public override void MakeSound()
        {
            Console.WriteLine(this._sound);
        }

        public override string ToString()
        {
            return $"{this._breed} {this._foodEaten}";
        }
    }
}