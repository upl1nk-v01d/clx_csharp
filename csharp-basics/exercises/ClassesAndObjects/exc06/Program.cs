class DogTest
{
    private static DogsList dogsList = new DogsList();

    static private void Main(string[] args)
    {
        string[,] _dogs = {
            {"Max", "male"},
            {"Rocky", "male"},
            {"Sparky", "male"},
            {"Buster", "male"},
            {"Sam", "male"},
            {"Lady", "female"},
            {"Molly", "female"},
            {"Coco", "female"}
        };

        string[,] _dogParents = {
            {"Max", "Lady", "Rocky"},
            {"Rocky", "Molly", "Sam"},
            {"Buster", "Lady", "Sparky"},
            {"Coco", "Molly", "Buster"}
        };
        
        Console.Clear();

        for(int i = 0; i < _dogs.GetLength(0);i++)
        {
            dogsList.NewDog(_dogs[i,0], _dogs[i,1]);
        }

        Console.WriteLine("\nPress any key to see dogs parents...");
        Console.ReadKey(true);
        Console.Clear();

        Console.WriteLine(dogsList.ListDogs());

        Console.WriteLine("\nWhat? Unknown parents for doggies??");
        Console.WriteLine("Let's add some known ones...");
        Console.WriteLine("Press any key to see added dogs parents...");
        Console.ReadKey(true);
        Console.Clear();

        Console.WriteLine("Added some parents data for dogs: \n");

        for(int i = 0; i < _dogParents.GetLength(0);i++)
        {
            dogsList.AddParent(_dogParents[i,0], _dogParents[i,1], _dogParents[i,2]);
        }
        
        Console.WriteLine(dogsList.ListDogs());

        Console.WriteLine("\nLet's see if some doggies have same mothers!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
        Console.Clear();

        var dogs = dogsList.ReturnDogs();

        foreach(var dogToCheck in dogs)
        {
            foreach(var dog in dogs)
            {
                if(dogToCheck != dog && dogToCheck.mother != null)
                {
                    dogToCheck.HasSameMotherAs(dog);
                    Console.WriteLine($"{dogToCheck.Name} has same mother {dogToCheck.mother} with {dog.Name}");
                }
            }
        }
    }
}
