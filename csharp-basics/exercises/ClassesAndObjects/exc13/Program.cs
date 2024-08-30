using System;
using System.Collections.Generic;

class Smoothie
{
    public string[] Ingredients;

    public double Price;

    public Smoothie(string[] ingredients, double price)
    {
        Ingredients = ingredients; 
        Price = price;
    }
    
    public double GetCost()
    {
        Console.WriteLine ("£" + Convert.ToString(Price));

        return Price;
    }

    public void GetPrice()
    {
        double price = this.GetCost();
        double calc = price + price * 1.5;

        Console.WriteLine ("£" + Convert.ToString(calc));
    }

    public void GetName()
    {
        string output = "";
        Array.Sort(this.Ingredients);

        if(this.Ingredients.Length > 1)
        {
            foreach(var item in this.Ingredients)
            {
                output += item + " ";
            }

            output += "Fusion";
        }
        else
        {
            output += this.Ingredients[0] + " Smoothie";
        }

        Console.WriteLine(output);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Let's create first smoothie!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        var smoothie1 = new Smoothie(new string[] { "Banana" }, 0.5);
        smoothie1.GetCost();
        smoothie1.GetPrice();
        smoothie1.GetName();

        Console.WriteLine("As we can see a smoothie is created!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        Console.Clear();
        Console.WriteLine("Now let's create another one!");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);

        var smoothie2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries"  }, 3.50);
        smoothie2.GetCost();
        smoothie2.GetPrice();
        smoothie2.GetName();
        
        Console.WriteLine("We created our second smoothie!");
        Console.WriteLine("\nPress any key to quit program...");
        Console.ReadKey(true);
    }
}

