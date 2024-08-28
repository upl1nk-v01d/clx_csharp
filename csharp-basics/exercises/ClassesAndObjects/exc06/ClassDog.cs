class Dog
{
    public string Name { get; set; }

    public string Sex { get; set; }

    public string mother { get; set; }

    public string father { get; set; }

    public Dog(string name, string sex)
    {
        Name = name;
        Sex = sex;
        mother = null;
        father = null;
    }

    public bool HasSameMotherAs(Dog otherDog)
    {
        return true;
    }
}

class DogsList
{
    private List<Dog> dogs = new List<Dog>();

    public void NewDog(string name, string sex)
    {
        dogs.Add(new Dog(name, sex));
        Console.WriteLine($"A {sex} dog with {name} has been born! :)");
    }

    public string ListDogs()
    {
        string output = "";

        foreach(var dog in dogs)
        {
            string mother = dog.mother == null ? "unknown" : dog.mother;
            string father = dog.father == null ? "unknown" : dog.father;

            output += $"{dog.Sex} {dog.Name} with mother {mother} and father {father}\n";
        }

        return output;
    }

    public List<Dog> ReturnDogs()
    {
        return dogs;
    }
    
    public void AddParent(string name, string mother, string father)
    {
        foreach(var dog in dogs)
        {
            if(name == dog.Name)
            {
                dog.mother = mother;
                dog.father = father;
                return;
            }
        }
    }
}
