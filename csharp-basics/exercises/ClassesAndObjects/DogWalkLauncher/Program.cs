using System;

namespace DogWalkLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             DogOwner owner = new DogOwner();
             Dog dog1 = new Dog();
             Dog dog2 = new Dog();
             */

            var testDogWalk1 = false;
            var testDogWalk2 = false;

            // Specify when the dogs last drank.
            /*
             dog1.SetDrinkTime(2);
             dog2.SetDrinkTime(5); 
              */

            // Test the negation of a condition.
            /*
            if (!owner.takeForWalk(dog1))
            {
                testDogWalk1 = true;
            }

            if (owner.takeForWalk(dog2))
            {
                testDogWalk2 = true;
            }
            */
            Console.WriteLine("testDogWalk1: " + testDogWalk1);
            Console.WriteLine("testDogWalk2: " + testDogWalk2);
        }
    }
}