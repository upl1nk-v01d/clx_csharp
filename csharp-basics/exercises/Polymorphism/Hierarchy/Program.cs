using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apples = new Vegetables(1);    
            //{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]
            Animal cat = new Cat("Snowbell","Cat", 3.12, 1, "Fluffy", "Latvia", apples);
            
            //string foodType = apples.GetType().Name;
            //Console.WriteLine(foodType);
            Console.Write($"{cat._animalType} {cat._animalName} {cat._animalWeight} ");
            Console.Write($"{cat._breed} {cat._foodEaten}");
            Console.WriteLine($"{cat.eat(apples)}!");
        }
    }
}