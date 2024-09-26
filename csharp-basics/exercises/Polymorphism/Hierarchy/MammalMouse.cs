using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {        
        public string Sound = "peeek";

        public Mouse(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _livingRegion = livingRegion;
            _foodType = foodType;
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Sound);
        }
    }
}