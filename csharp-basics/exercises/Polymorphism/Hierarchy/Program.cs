using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Food apples = new Vegetables(1);    
            Food meat = new Meat(2);    

            Animal cat = new Cat("Snowbell","Cat", 3.12, 1, "Persian", "Persia", apples);
            Animal tiger = new Tiger("Typho","Tiger", 121.3, 1, "Africa", meat);
            
            Console.WriteLine($"{cat._animalType} {cat._animalName} {cat._animalWeight} {cat}");
            Console.WriteLine(cat.Eat(apples));
            cat.MakeSound();

            Console.Write($"{tiger._animalType} {tiger._animalName} ");
            Console.WriteLine($"{tiger._animalWeight} {tiger}");
            Console.WriteLine(tiger.Eat(meat));
            tiger.MakeSound();
        }
    }
}