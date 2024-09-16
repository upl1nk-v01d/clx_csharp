using System;

namespace Hierarchy
{
    public class Tiger : Mammal
    {        
        public string Sound = "ROAR!";

        public Tiger(string animalName, string animalType, double animalWeight, 
        int foodEaten, string livingRegion, Food foodType) 
        : base(animalName, animalType, animalWeight, foodEaten, livingRegion, foodType)
        {
            _livingRegion = livingRegion;
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Sound);
        }

        public override string ToString()
        {
            return $"{this._livingRegion} {this._foodEaten}";
        }

        public override string GetLivingRegion()
        {
            return $"{this._livingRegion}";
        }
    }
}