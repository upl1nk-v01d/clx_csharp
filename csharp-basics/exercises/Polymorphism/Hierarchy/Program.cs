using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apples = new Vegetables(1);    
            Food meat = new Meat(2);    

            Animal cat = new Cat("Snowbell","Cat", 3.12, 1, "Persian", "Persia", apples);
            Animal tiger = new Tiger("Typho","Tiger", 121.3, 1, "Africa", meat);
            
            Console.WriteLine($"{cat._animalType} {cat._animalName} {cat._animalWeight} {cat}");
            Console.WriteLine(cat.eat(apples));
            cat.makeSound();

            Console.WriteLine($"{tiger._animalType} {tiger._animalName} {tiger._animalWeight} {tiger}");
            Console.WriteLine(tiger.eat(meat));
            tiger.makeSound();
        }
    }
}